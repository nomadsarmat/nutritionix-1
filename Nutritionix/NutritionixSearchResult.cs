using System.Runtime.Serialization;

namespace Nutritionix
{
    [DataContract]
    public class NutritionixSearchResult
    {
        [DataMember(Name = "item_id")]
        public string ItemId { get; set; }

        [DataMember(Name = "item_name")]
        public string ItemName { get; set; }

        [DataMember(Name = "brand_name")]
        public string BrandName { get; set; }

        [DataMember(Name = "calories")]
        public string Calories { get; set; }

        [DataMember(Name = "calories_unit")]
        public string CaloriesUnit { get; set; }
    }
}