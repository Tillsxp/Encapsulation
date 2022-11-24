namespace övning;

class Mobile 
{
private int _socialsecurity; // Public eller private?

    public Guid UserId{ get;} = Guid.NewGuid();// använder bara get som skrivsskydd, som ersättning av readonly
    public string MobileNumber { get; set;} = ""; // Egenskapen har skapat och välen fält genom auto-implemtering
    public string FullName {get; private set;} = ""; // Kollar Social Security och sätter matchade namn
    public int SocialSecurity{set{ if(IsValid()){ _socialsecurity = value; } ;} } // value??

    private bool IsValid() {  return true; }
}
