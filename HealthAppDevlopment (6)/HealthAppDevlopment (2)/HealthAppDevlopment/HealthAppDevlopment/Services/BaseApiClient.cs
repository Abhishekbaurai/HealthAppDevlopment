using HealthAppDevlopment.DataModels;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using static System.Net.WebRequestMethods;

namespace HealthAppDevlopment.Services
{
	public class BaseApiClient : IBaseApiClient
	{
		//public string BaseUrl { get; set; } = "https://myhealthdiet.azurewebsites.net/FamilyInfo";
		//public IDBClient DBClient;
		public IJSRuntime runtime;
		public string AppCode;


		public async Task<FamilyDetail> MakeRequest<T>(string apiUrl, string httpMethod, Dictionary<string, string> postParams = null,  bool showConfirmMessage = false)
		{
				using (var client = new HttpClient())
				{
					HttpRequestMessage requestMessage = new HttpRequestMessage(new HttpMethod(httpMethod), $"{apiUrl}");
					if (postParams != null)
						requestMessage.Content = new FormUrlEncodedContent(postParams);
					HttpResponseMessage response = await client.SendAsync(requestMessage);
					string apiResponse = await response.Content.ReadAsStringAsync();
					try
					{
						if (apiResponse != "")
							return JsonConvert.DeserializeObject<FamilyDetail>(apiResponse);
						else
							throw new Exception();
					}
					catch (Exception ex)
					{
						var realException = $"An error ocurred while calling the API. It responded with the following message: {response.StatusCode} {response.ReasonPhrase}" + ex.Message;
						throw new Exception(realException);
					}
					finally
					{
					}
				}
		}
		public async Task<FoodNutrition[]> Request<T>(string apiUrl, string httpMethod, Dictionary<string,string> postParams = null, bool showConfirmMessage = false)
		{
			using (var client = new HttpClient())
			{
				HttpRequestMessage requestMessage = new HttpRequestMessage(new HttpMethod(httpMethod), $"{apiUrl}");
				if (postParams != null)
					requestMessage.Content = new FormUrlEncodedContent(postParams);
				HttpResponseMessage response = await client.SendAsync(requestMessage);
				string apiResponse = await response.Content.ReadAsStringAsync();
				try
				{
					if (apiResponse != "")
						return JsonConvert.DeserializeObject<FoodNutrition[]>(apiResponse);
					else
						throw new Exception();
				}
				catch (Exception ex)
				{
					var realException = $"An error ocurred while calling the API. It responded with the following message: {response.StatusCode} {response.ReasonPhrase}" + ex.Message;
					throw new Exception(realException);
				}
				finally
				{
				}
			}
		}
		public async Task<MealModel[]> RequestForGetMealTypes<T>(string apiUrl, string httpMethod, Dictionary<string, string> postParams = null, bool showConfirmMessage = false)
		{
			using (var client = new HttpClient())
			{
				HttpRequestMessage requestMessage = new HttpRequestMessage(new HttpMethod(httpMethod), $"{apiUrl}");
				if (postParams != null)
					requestMessage.Content = new FormUrlEncodedContent(postParams);
				HttpResponseMessage response = await client.SendAsync(requestMessage);
				string apiResponse = await response.Content.ReadAsStringAsync();
				try
				{
					if (apiResponse != "")
						return JsonConvert.DeserializeObject<MealModel[]>(apiResponse);
					else
						throw new Exception();
				}
				catch (Exception ex)
				{
					var realException = $"An error ocurred while calling the API. It responded with the following message: {response.StatusCode} {response.ReasonPhrase}" + ex.Message;
					throw new Exception(realException);
				}
				finally
				{
				}
			}
		}
		//        public static async Task<T> MakeRequestWithAuthKey<T>(string apiUrl, string httpMethod, string auth)
		//        {
		//            using var client = new HttpClient();
		//            HttpRequestMessage requestMessage = new HttpRequestMessage(new HttpMethod(httpMethod), $"{apiUrl}");
		//            requestMessage.Headers.Add("Authorization", "Basic " + auth);
		//            HttpResponseMessage response = await client.SendAsync(requestMessage);
		//            string apiResponse = await response.Content.ReadAsStringAsync();
		//            try
		//            {
		//                if (apiResponse != "")
		//                {
		//                    return JsonConvert.DeserializeObject<T>(apiResponse);
		//                }
		//                else
		//                {
		//                    throw new Exception();
		//                }
		//            }
		//            catch (Exception ex)
		//            {
		//                var realException = $"An error ocurred while calling the API. It responded with the following message: {response.StatusCode} {response.ReasonPhrase}" + ex.Message;
		//                throw new Exception(realException);
		//            }
		//            finally
		//            {
		//            }
		//        }​
		//        public async Task<T> MakeRequestMultipartUpload<T>(string apiUrl, string httpMethod, byte[] imageBytes, string imageExtension, Dictionary<string, string> postParams = null)
		//        {
		//            try
		//            {
		//                var content = new MultipartFormDataContent();
		//                if (imageBytes != null && imageBytes.Length > 0)
		//                {
		//                    var fileContent = new ByteArrayContent(imageBytes);
		//                    fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
		//                    {
		//                        FileName = Guid.NewGuid() + "." + "jpeg",
		//                        Name = "photo"
		//                    };
		//                    fileContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");
		//                    content.Add(fileContent);
		//                }
		//​
		//                foreach (var item in postParams)
		//                {
		//                    Console.WriteLine(item.Key + " " + item.Value);
		//                }
		//                content.Add(new StringContent(postParams["PostType"]), "postType");
		//                content.Add(new StringContent(postParams["Id"]), "id");
		//                if (!string.IsNullOrEmpty(postParams["Comment"]))
		//                    content.Add(new StringContent(postParams["Comment"]), "comment");
		//​
		//                using (var client = new HttpClient())
		//                {
		//                    //string uri = string.Format("{0}/ActivityFeed/CreateOrUpdateActivityFeedPost?auth={1}", BaseUrl, authToken);
		//                    string uri = string.Format("{0}/ActivityFeed/CreateOrUpdateActivityFeedPostV1?auth={1}", BaseUrl, postParams["auth"]);
		//                    Task<HttpResponseMessage> contentsTask = client.PostAsync(uri, content);
		//                    var jsonResponse = await contentsTask.Result.Content.ReadAsStringAsync().ConfigureAwait(false);
		//                    if (!string.IsNullOrEmpty(jsonResponse))
		//                    {
		//                        return JsonConvert.DeserializeObject<T>(jsonResponse);
		//                    }
		//                    else
		//                    {
		//                        throw new Exception();
		//                    }
		//                }
		//            }
		//            catch (Exception ex)
		//            {
		//                throw new Exception(ex.Message);
		//            }
		//        }
		//​
		//​
		//        public async Task<bool> MakeRequestWithStatusCode(string apiUrl, string httpMethod, object obj)
		//        {
		//            using var client = new HttpClient();
		//            HttpRequestMessage requestMessage = new HttpRequestMessage(new HttpMethod(httpMethod), $"{apiUrl}");
		//            string JsonBody = JsonConvert.SerializeObject(obj);
		//            requestMessage.Content = new StringContent(JsonBody, Encoding.UTF8, "application/json");
		//            HttpResponseMessage response = await client.SendAsync(requestMessage);
		//            try
		//            {
		//                return response.IsSuccessStatusCode;
		//            }
		//            catch (Exception ex)
		//            {
		//                var realException = $"An error ocurred while calling the API. It responded with the following message: {response.StatusCode} {response.ReasonPhrase}" + ex.Message;
		//                throw new Exception(realException);
		//            }
		//            finally
		//            {
		//            }
		//        }
	}


}
