/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HoneybeeDotNet.Client.OpenAPIDateConverter;

namespace HoneybeeDotNet.Model
{
    /// <summary>
    /// Used to define a schedule for a default day, further described by ScheduleRule.
    /// </summary>
    [DataContract]
    public partial class ScheduleRulesetAbridged :  IEquatable<ScheduleRulesetAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleRulesetAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleRulesetAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleRulesetAbridged" /> class.
        /// </summary>
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="daySchedules">A list of ScheduleDays that are referenced in the other keys of this ScheduleRulesetAbridged. (required).</param>
        /// <param name="defaultDaySchedule">A name for the ScheduleDay that will be used for all days when no ScheduleRule is applied. This ScheduleDay must be in the day_schedules. (required).</param>
        /// <param name="type">type (default to &quot;ScheduleRulesetAbridged&quot;).</param>
        /// <param name="scheduleRules">A list of ScheduleRuleAbridged that note exceptions to the default_day_schedule. These rules should be ordered from highest to lowest priority..</param>
        /// <param name="summerDesigndaySchedule">A name for the ScheduleDay that will be used for the summer design day. This ScheduleDay must be in the day_schedules..</param>
        /// <param name="winterDesigndaySchedule">A name for the ScheduleDay that will be used for the winter design day. This ScheduleDay must be in the day_schedules..</param>
        /// <param name="scheduleTypeLimit">Name of a ScheduleTypeLimit that will be used to validate schedule values against upper/lower limits and assign units to the schedule values. If None, no validation will occur..</param>
        public ScheduleRulesetAbridged(string name, List<ScheduleDay> daySchedules, string defaultDaySchedule, string type = "ScheduleRulesetAbridged", List<ScheduleRuleAbridged> scheduleRules = default(List<ScheduleRuleAbridged>), string summerDesigndaySchedule = default(string), string winterDesigndaySchedule = default(string), string scheduleTypeLimit = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ScheduleRulesetAbridged and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "daySchedules" is required (not null)
            if (daySchedules == null)
            {
                throw new InvalidDataException("daySchedules is a required property for ScheduleRulesetAbridged and cannot be null");
            }
            else
            {
                this.DaySchedules = daySchedules;
            }
            
            // to ensure "defaultDaySchedule" is required (not null)
            if (defaultDaySchedule == null)
            {
                throw new InvalidDataException("defaultDaySchedule is a required property for ScheduleRulesetAbridged and cannot be null");
            }
            else
            {
                this.DefaultDaySchedule = defaultDaySchedule;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "ScheduleRulesetAbridged";
            }
            else
            {
                this.Type = type;
            }
            this.ScheduleRules = scheduleRules;
            this.SummerDesigndaySchedule = summerDesigndaySchedule;
            this.WinterDesigndaySchedule = winterDesigndaySchedule;
            this.ScheduleTypeLimit = scheduleTypeLimit;
        }
        
        /// <summary>
        /// Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A list of ScheduleDays that are referenced in the other keys of this ScheduleRulesetAbridged.
        /// </summary>
        /// <value>A list of ScheduleDays that are referenced in the other keys of this ScheduleRulesetAbridged.</value>
        [DataMember(Name="day_schedules", EmitDefaultValue=false)]
        [JsonProperty("day_schedules")]
        public List<ScheduleDay> DaySchedules { get; set; }

        /// <summary>
        /// A name for the ScheduleDay that will be used for all days when no ScheduleRule is applied. This ScheduleDay must be in the day_schedules.
        /// </summary>
        /// <value>A name for the ScheduleDay that will be used for all days when no ScheduleRule is applied. This ScheduleDay must be in the day_schedules.</value>
        [DataMember(Name="default_day_schedule", EmitDefaultValue=false)]
        [JsonProperty("default_day_schedule")]
        public string DefaultDaySchedule { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A list of ScheduleRuleAbridged that note exceptions to the default_day_schedule. These rules should be ordered from highest to lowest priority.
        /// </summary>
        /// <value>A list of ScheduleRuleAbridged that note exceptions to the default_day_schedule. These rules should be ordered from highest to lowest priority.</value>
        [DataMember(Name="schedule_rules", EmitDefaultValue=false)]
        [JsonProperty("schedule_rules")]
        public List<ScheduleRuleAbridged> ScheduleRules { get; set; }

        /// <summary>
        /// A name for the ScheduleDay that will be used for the summer design day. This ScheduleDay must be in the day_schedules.
        /// </summary>
        /// <value>A name for the ScheduleDay that will be used for the summer design day. This ScheduleDay must be in the day_schedules.</value>
        [DataMember(Name="summer_designday_schedule", EmitDefaultValue=false)]
        [JsonProperty("summer_designday_schedule")]
        public string SummerDesigndaySchedule { get; set; }

        /// <summary>
        /// A name for the ScheduleDay that will be used for the winter design day. This ScheduleDay must be in the day_schedules.
        /// </summary>
        /// <value>A name for the ScheduleDay that will be used for the winter design day. This ScheduleDay must be in the day_schedules.</value>
        [DataMember(Name="winter_designday_schedule", EmitDefaultValue=false)]
        [JsonProperty("winter_designday_schedule")]
        public string WinterDesigndaySchedule { get; set; }

        /// <summary>
        /// Name of a ScheduleTypeLimit that will be used to validate schedule values against upper/lower limits and assign units to the schedule values. If None, no validation will occur.
        /// </summary>
        /// <value>Name of a ScheduleTypeLimit that will be used to validate schedule values against upper/lower limits and assign units to the schedule values. If None, no validation will occur.</value>
        [DataMember(Name="schedule_type_limit", EmitDefaultValue=false)]
        [JsonProperty("schedule_type_limit")]
        public string ScheduleTypeLimit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleRulesetAbridged {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DaySchedules: ").Append(DaySchedules).Append("\n");
            sb.Append("  DefaultDaySchedule: ").Append(DefaultDaySchedule).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ScheduleRules: ").Append(ScheduleRules).Append("\n");
            sb.Append("  SummerDesigndaySchedule: ").Append(SummerDesigndaySchedule).Append("\n");
            sb.Append("  WinterDesigndaySchedule: ").Append(WinterDesigndaySchedule).Append("\n");
            sb.Append("  ScheduleTypeLimit: ").Append(ScheduleTypeLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleRulesetAbridged);
        }

        /// <summary>
        /// Returns true if ScheduleRulesetAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleRulesetAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleRulesetAbridged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DaySchedules == input.DaySchedules ||
                    this.DaySchedules != null &&
                    input.DaySchedules != null &&
                    this.DaySchedules.SequenceEqual(input.DaySchedules)
                ) && 
                (
                    this.DefaultDaySchedule == input.DefaultDaySchedule ||
                    (this.DefaultDaySchedule != null &&
                    this.DefaultDaySchedule.Equals(input.DefaultDaySchedule))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ScheduleRules == input.ScheduleRules ||
                    this.ScheduleRules != null &&
                    input.ScheduleRules != null &&
                    this.ScheduleRules.SequenceEqual(input.ScheduleRules)
                ) && 
                (
                    this.SummerDesigndaySchedule == input.SummerDesigndaySchedule ||
                    (this.SummerDesigndaySchedule != null &&
                    this.SummerDesigndaySchedule.Equals(input.SummerDesigndaySchedule))
                ) && 
                (
                    this.WinterDesigndaySchedule == input.WinterDesigndaySchedule ||
                    (this.WinterDesigndaySchedule != null &&
                    this.WinterDesigndaySchedule.Equals(input.WinterDesigndaySchedule))
                ) && 
                (
                    this.ScheduleTypeLimit == input.ScheduleTypeLimit ||
                    (this.ScheduleTypeLimit != null &&
                    this.ScheduleTypeLimit.Equals(input.ScheduleTypeLimit))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DaySchedules != null)
                    hashCode = hashCode * 59 + this.DaySchedules.GetHashCode();
                if (this.DefaultDaySchedule != null)
                    hashCode = hashCode * 59 + this.DefaultDaySchedule.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ScheduleRules != null)
                    hashCode = hashCode * 59 + this.ScheduleRules.GetHashCode();
                if (this.SummerDesigndaySchedule != null)
                    hashCode = hashCode * 59 + this.SummerDesigndaySchedule.GetHashCode();
                if (this.WinterDesigndaySchedule != null)
                    hashCode = hashCode * 59 + this.WinterDesigndaySchedule.GetHashCode();
                if (this.ScheduleTypeLimit != null)
                    hashCode = hashCode * 59 + this.ScheduleTypeLimit.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // DefaultDaySchedule (string) maxLength
            if(this.DefaultDaySchedule != null && this.DefaultDaySchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DefaultDaySchedule, length must be less than 100.", new [] { "DefaultDaySchedule" });
            }

            // DefaultDaySchedule (string) minLength
            if(this.DefaultDaySchedule != null && this.DefaultDaySchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DefaultDaySchedule, length must be greater than 1.", new [] { "DefaultDaySchedule" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^ScheduleRulesetAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // SummerDesigndaySchedule (string) maxLength
            if(this.SummerDesigndaySchedule != null && this.SummerDesigndaySchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SummerDesigndaySchedule, length must be less than 100.", new [] { "SummerDesigndaySchedule" });
            }

            // SummerDesigndaySchedule (string) minLength
            if(this.SummerDesigndaySchedule != null && this.SummerDesigndaySchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SummerDesigndaySchedule, length must be greater than 1.", new [] { "SummerDesigndaySchedule" });
            }

            // WinterDesigndaySchedule (string) maxLength
            if(this.WinterDesigndaySchedule != null && this.WinterDesigndaySchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WinterDesigndaySchedule, length must be less than 100.", new [] { "WinterDesigndaySchedule" });
            }

            // WinterDesigndaySchedule (string) minLength
            if(this.WinterDesigndaySchedule != null && this.WinterDesigndaySchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WinterDesigndaySchedule, length must be greater than 1.", new [] { "WinterDesigndaySchedule" });
            }

            // ScheduleTypeLimit (string) maxLength
            if(this.ScheduleTypeLimit != null && this.ScheduleTypeLimit.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScheduleTypeLimit, length must be less than 100.", new [] { "ScheduleTypeLimit" });
            }

            // ScheduleTypeLimit (string) minLength
            if(this.ScheduleTypeLimit != null && this.ScheduleTypeLimit.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScheduleTypeLimit, length must be greater than 1.", new [] { "ScheduleTypeLimit" });
            }

            yield break;
        }
    }

}
