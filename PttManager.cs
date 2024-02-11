using Business.Abstract;
using Entities;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService) // Constructor new yapıldığında çalışır
    {
        _applicantService = applicantService;
    }
    
    public void GiveMask(Person person)
    {
        PersonManager personManager = new PersonManager();
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine(person.Firstname + "için maske verildi");
        }
        else
        {
            Console.WriteLine(person.Firstname + "verilemedi.");
        }
    }
}