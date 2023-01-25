using Newtonsoft.Json;

namespace HealthAppDevlopment.DataModels
{
	public class FoodNutrition
	{
		[JsonProperty(propertyName: "id")]
		public int Id { get; set; }
		[JsonProperty(propertyName: "name")]
		public string Name { get; set; }
		[JsonProperty(propertyName: "foodGroupId")]
		public int FoodGroupId { get; set; }
		[JsonProperty(propertyName: "calories")]
		public double Calories { get; set; }
		[JsonProperty(propertyName: "fat")]
		public double Fat { get; set; }
		[JsonProperty(propertyName: "protein")]
		public double Protein { get; set; }
		[JsonProperty(propertyName: "carbohydrate")]
		public double Carbohydrate { get; set; }
		[JsonProperty(propertyName: "fiber")]
		public double Fiber { get; set; }
		[JsonProperty(propertyName: "vitaminAIU")]
		public double VitaminAIU { get; set; }
		[JsonProperty(propertyName: "vitaminARAE")]
		public double VitaminARAE { get; set; }
		[JsonProperty(propertyName: "vitaminB12")]
		public double VitaminB12 { get; set; }
		[JsonProperty(propertyName: "vitaminC")]
		public double VitaminC { get; set; }
		[JsonProperty(propertyName: "vitaminD")]
		public double VitaminD { get; set; }
		[JsonProperty(propertyName: "vitaminE")]
		public double VitaminE { get; set; }
		[JsonProperty(propertyName: "servingWeight1")]
		public double ServingWeight1 { get; set; }
		[JsonProperty(propertyName: "servingDescription1")]
		public string ServingDescription1 { get; set; }
		[JsonProperty(propertyName: "servingWeight2")]
		public double ServingWeight2 { get; set; }
		[JsonProperty(propertyName: "servingDescription2")]
		public string ServingDescription2 { get; set; }
		[JsonProperty(propertyName: "servingWeight3")]
		public double ServingWeight3 { get; set; }
		[JsonProperty(propertyName: "servingDescription3")]
		public string ServingDescription3 { get; set; }
	}
}
