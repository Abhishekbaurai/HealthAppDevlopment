using Newtonsoft.Json;
namespace HealthAppDevlopment.DataModels
{
	public class MealModel
	{
		public string Discription { get; set; }
		[JsonProperty(propertyName: "id")]
		public int Id { get; set; }
		[JsonProperty(propertyName: "mealTypeCategory")]
		public string MealTypeCategory { get; set; }
		//[JsonProperty(propertyName: "calories")]
		//public int Calories { get; set; }
		//[JsonProperty(propertyName: "proteins")]
		//public int Proteins { get; set; }
		//[JsonProperty(propertyName: "fats")]
		//public int Fats { get; set; }
		//[JsonProperty(propertyName: "carbs")]
		//public int Carbs { get; set; }
		//[JsonProperty(propertyName: "fiber")]
		//public int Fiber { get; set; }
		[JsonProperty(propertyName: "bestTime")]
		public string BestTime { get; set; }
		[JsonProperty(propertyName: "order")]
		public int Order { get; set; }
	}
}