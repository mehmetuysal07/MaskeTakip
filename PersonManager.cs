using Business.Abstract;
using Business.KPSPublic;
using Entities;

namespace Business.Concrete;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        
    }

    public List<Person> GetList()
    {
        return null;
    }

    public bool CheckPerson(Person person)
    {
        KPSPublicSoap client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client
            .TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(person.NationalIdentiy,person.Firstname,person.Lastname,person.DateOfBirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;
        
        
    }
}