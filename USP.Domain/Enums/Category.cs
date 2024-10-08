using Ardalis.SmartEnum;

namespace USP.Domain.Enums;

public abstract class Category(string name, int value) : SmartEnum<Category>(name, value)
{
    public abstract string NameOfCategory { get; }
    public abstract string DescriptionOfCategory { get; }
   
    
    public static Category Sport = new SportCategory();
    public static Category Muzika = new MuzikaCategory();
    public abstract string CheckSubCategory();
    
    
    
    
    private class SportCategory() : Category(nameof(Sport), 0)
    {
        public override string NameOfCategory => "Sport";
        public override string DescriptionOfCategory => "Neki opis za sport";
        

        public override string CheckSubCategory()
        {
            throw new NotImplementedException();
        }
    }
    private class MuzikaCategory() : Category(nameof(Muzika), 1)
    {
        public override string NameOfCategory => "Muzika";
        public override string DescriptionOfCategory => "Neki opis za muziku";
        

        public override string CheckSubCategory()
        {
            throw new NotImplementedException();
        }
    }

}















