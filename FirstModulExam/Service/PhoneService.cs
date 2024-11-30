using FirstModulExam.Moduls;

namespace FirstModulExam.Service;

public class PhoneService
{
      private List<Phone> phones;

      public PhoneService(List<Phone> phone)
      {
            phone = new List<Phone>();
      }

      public Phone AddPhone(Phone phone)
      {
            var phoneId = phone.Id;
            phones.Add(phone);
            return phone;
      }

      public Phone GetById(Guid id)
      {
            foreach (var phone in phones)
            {
                  if (phone.Id == id)
                  {
                        return phone;
                  }
            }
            return null;
      }

      public bool Delete(Phone DeleteCar)
      {
            var phone = GetById(DeleteCar.Id);
            phones.Remove(phone);
            return true;
      }

      public bool Update(Phone updateCar)
      {
            var phone = GetById(updateCar.Id);

            if (phone is null)
            {
                  return false;
            }

            var index = phones.IndexOf(phone);
            phones[index] = updateCar;

            return true;
      }

      public List<Phone> GetAll()
      {
            return phones;
      }
}