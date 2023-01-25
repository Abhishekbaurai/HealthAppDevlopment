using HealthAppDevlopment.DataModels;

namespace HealthAppDevlopment.Services
{
    public interface IBaseApiClient
    {
        Task<FamilyDetail> MakeRequest<T>(string apiUrl, string httpMethod, Dictionary<string, string> postParams = null, bool showConfirmMessage = false);
        Task<FoodNutrition[]> Request<T>(string apiUrl, string httpMethod, Dictionary<string, string> postParams = null, bool showConfirmMessage = false);
		Task<MealModel[]> RequestForGetMealTypes<T>(string apiUrl, string httpMethod, Dictionary<string, string> postParams = null, bool showConfirmMessage = false);
	
    }
}
