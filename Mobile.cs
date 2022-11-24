namespace övning;

class Mobile 
{
private int _socialsecurity; 

    public Guid UserId{ get;} = Guid.NewGuid();// använder bara get som skrivsskydd, som ersättning av readonly
    public string MobileNumber { get; set;} = ""; // Egenskapen har skapat och välen fält genom auto-implemtering
    public string FullName {get; private set;} = "";  //Private set, sätts av företaget
    public int SocialSecurity{set{ if(IsValid()){ _socialsecurity = value; } ;} } // Om IsValid är sant, sätt värde

    private bool IsValid() {  return true; }
}
