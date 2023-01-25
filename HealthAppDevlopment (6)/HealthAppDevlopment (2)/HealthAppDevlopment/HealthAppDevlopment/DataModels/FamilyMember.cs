using Newtonsoft.Json;

namespace HealthAppDevlopment.DataModels
{
    public class FamilyMember
    {
        [JsonProperty(propertyName: "id")]
        public int Id { get; set; }
        [JsonProperty(propertyName: "familyId")]
        public int FamilyId { get; set; }
        [JsonProperty(propertyName: "memberName")]
        public string? MemberName { get; set; }
        [JsonProperty(propertyName: "memberCode")]
        public string? MemberCode { get; set; }
        [JsonProperty(propertyName: "dateOfBirth")]
        public DateTime DateOfBirth { get; set; }
        [JsonProperty(propertyName: "uniqueCode")]
        public string? UniqueCode { get; set; }
        [JsonProperty(propertyName: "bloodGroup")]
        public string? BloodGroup { get; set; }
        [JsonProperty(propertyName: "familyMeberDtos")]
        public List<object> FamilyMeberDtos { get; set; }
    }
}
