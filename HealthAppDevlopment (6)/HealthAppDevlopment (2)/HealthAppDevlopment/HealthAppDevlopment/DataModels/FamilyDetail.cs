using Newtonsoft.Json;

namespace HealthAppDevlopment.DataModels
{
    public class FamilyDetail
    {

        [JsonProperty(propertyName: "id")]
        public int Id { get; set; }
        [JsonProperty(propertyName: "familyName")]
        public string? FamilyName { get; set; }
        [JsonProperty(propertyName: "familyCode")]
        public string? FamilyCode { get; set; }
        [JsonProperty(propertyName: "address")]
        public string? Address { get; set; }
        [JsonProperty(propertyName: "uniqueCode")]
        public string? UniqueCode { get; set; }
        public List<FamilyMember> FamilyMembers { get; set; }
    }
}
