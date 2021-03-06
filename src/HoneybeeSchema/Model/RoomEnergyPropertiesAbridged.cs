/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.17.0
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


namespace HoneybeeSchema
{
    /// <summary>
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [DataContract]
    public partial class RoomEnergyPropertiesAbridged :  IEquatable<RoomEnergyPropertiesAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="type">type (default to &quot;RoomEnergyPropertiesAbridged&quot;).</param>
        /// <param name="constructionSet">Name of a ConstructionSet to specify all default constructions for the Faces, Apertures, and Doors of the Room. If None, the Room will use the Model global_construction_set..</param>
        /// <param name="programType">Name of a ProgramType to specify all default schedules and loads for the Room. If None, the Room will have no loads or setpoints..</param>
        /// <param name="hvac">An optional name of a HVAC system (such as an IdealAirSystem) that specifies how the Room is conditioned. If None, it will be assumed that the Room is not conditioned..</param>
        /// <param name="people">People object to describe the occupancy of the Room..</param>
        /// <param name="lighting">Lighting object to describe the lighting usage of the Room..</param>
        /// <param name="electricEquipment">ElectricEquipment object to describe the electric equipment usage..</param>
        /// <param name="gasEquipment">GasEquipment object to describe the gas equipment usage..</param>
        /// <param name="infiltration">Infiltration object to to describe the outdoor air leakage..</param>
        /// <param name="ventilation">Ventilation object for the minimum outdoor air requirement..</param>
        /// <param name="setpoint">Setpoint object for the temperature setpoints of the Room..</param>
        public RoomEnergyPropertiesAbridged(string type = "RoomEnergyPropertiesAbridged", string constructionSet = default, string programType = default, string hvac = default, PeopleAbridged people = default, LightingAbridged lighting = default, ElectricEquipmentAbridged electricEquipment = default, GasEquipmentAbridged gasEquipment = default, InfiltrationAbridged infiltration = default, VentilationAbridged ventilation = default, SetpointAbridged setpoint = default)
        {
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "RoomEnergyPropertiesAbridged";
            }
            else
            {
                this.Type = type;
            }
            this.ConstructionSet = constructionSet;
            this.ProgramType = programType;
            this.Hvac = hvac;
            this.People = people;
            this.Lighting = lighting;
            this.ElectricEquipment = electricEquipment;
            this.GasEquipment = gasEquipment;
            this.Infiltration = infiltration;
            this.Ventilation = ventilation;
            this.Setpoint = setpoint;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Name of a ConstructionSet to specify all default constructions for the Faces, Apertures, and Doors of the Room. If None, the Room will use the Model global_construction_set.
        /// </summary>
        /// <value>Name of a ConstructionSet to specify all default constructions for the Faces, Apertures, and Doors of the Room. If None, the Room will use the Model global_construction_set.</value>
        [DataMember(Name="construction_set", EmitDefaultValue=false)]
        [JsonProperty("construction_set")]
        public string ConstructionSet { get; set; }

        /// <summary>
        /// Name of a ProgramType to specify all default schedules and loads for the Room. If None, the Room will have no loads or setpoints.
        /// </summary>
        /// <value>Name of a ProgramType to specify all default schedules and loads for the Room. If None, the Room will have no loads or setpoints.</value>
        [DataMember(Name="program_type", EmitDefaultValue=false)]
        [JsonProperty("program_type")]
        public string ProgramType { get; set; }

        /// <summary>
        /// An optional name of a HVAC system (such as an IdealAirSystem) that specifies how the Room is conditioned. If None, it will be assumed that the Room is not conditioned.
        /// </summary>
        /// <value>An optional name of a HVAC system (such as an IdealAirSystem) that specifies how the Room is conditioned. If None, it will be assumed that the Room is not conditioned.</value>
        [DataMember(Name="hvac", EmitDefaultValue=false)]
        [JsonProperty("hvac")]
        public string Hvac { get; set; }

        /// <summary>
        /// People object to describe the occupancy of the Room.
        /// </summary>
        /// <value>People object to describe the occupancy of the Room.</value>
        [DataMember(Name="people", EmitDefaultValue=false)]
        [JsonProperty("people")]
        public PeopleAbridged People { get; set; }

        /// <summary>
        /// Lighting object to describe the lighting usage of the Room.
        /// </summary>
        /// <value>Lighting object to describe the lighting usage of the Room.</value>
        [DataMember(Name="lighting", EmitDefaultValue=false)]
        [JsonProperty("lighting")]
        public LightingAbridged Lighting { get; set; }

        /// <summary>
        /// ElectricEquipment object to describe the electric equipment usage.
        /// </summary>
        /// <value>ElectricEquipment object to describe the electric equipment usage.</value>
        [DataMember(Name="electric_equipment", EmitDefaultValue=false)]
        [JsonProperty("electric_equipment")]
        public ElectricEquipmentAbridged ElectricEquipment { get; set; }

        /// <summary>
        /// GasEquipment object to describe the gas equipment usage.
        /// </summary>
        /// <value>GasEquipment object to describe the gas equipment usage.</value>
        [DataMember(Name="gas_equipment", EmitDefaultValue=false)]
        [JsonProperty("gas_equipment")]
        public GasEquipmentAbridged GasEquipment { get; set; }

        /// <summary>
        /// Infiltration object to to describe the outdoor air leakage.
        /// </summary>
        /// <value>Infiltration object to to describe the outdoor air leakage.</value>
        [DataMember(Name="infiltration", EmitDefaultValue=false)]
        [JsonProperty("infiltration")]
        public InfiltrationAbridged Infiltration { get; set; }

        /// <summary>
        /// Ventilation object for the minimum outdoor air requirement.
        /// </summary>
        /// <value>Ventilation object for the minimum outdoor air requirement.</value>
        [DataMember(Name="ventilation", EmitDefaultValue=false)]
        [JsonProperty("ventilation")]
        public VentilationAbridged Ventilation { get; set; }

        /// <summary>
        /// Setpoint object for the temperature setpoints of the Room.
        /// </summary>
        /// <value>Setpoint object for the temperature setpoints of the Room.</value>
        [DataMember(Name="setpoint", EmitDefaultValue=false)]
        [JsonProperty("setpoint")]
        public SetpointAbridged Setpoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomEnergyPropertiesAbridged {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ConstructionSet: ").Append(ConstructionSet).Append("\n");
            sb.Append("  ProgramType: ").Append(ProgramType).Append("\n");
            sb.Append("  Hvac: ").Append(Hvac).Append("\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  Lighting: ").Append(Lighting).Append("\n");
            sb.Append("  ElectricEquipment: ").Append(ElectricEquipment).Append("\n");
            sb.Append("  GasEquipment: ").Append(GasEquipment).Append("\n");
            sb.Append("  Infiltration: ").Append(Infiltration).Append("\n");
            sb.Append("  Ventilation: ").Append(Ventilation).Append("\n");
            sb.Append("  Setpoint: ").Append(Setpoint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RoomEnergyPropertiesAbridged object</returns>
        public static RoomEnergyPropertiesAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<RoomEnergyPropertiesAbridged>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoomEnergyPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if RoomEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of RoomEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomEnergyPropertiesAbridged input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ConstructionSet == input.ConstructionSet ||
                    (this.ConstructionSet != null &&
                    this.ConstructionSet.Equals(input.ConstructionSet))
                ) && 
                (
                    this.ProgramType == input.ProgramType ||
                    (this.ProgramType != null &&
                    this.ProgramType.Equals(input.ProgramType))
                ) && 
                (
                    this.Hvac == input.Hvac ||
                    (this.Hvac != null &&
                    this.Hvac.Equals(input.Hvac))
                ) && 
                (
                    this.People == input.People ||
                    (this.People != null &&
                    this.People.Equals(input.People))
                ) && 
                (
                    this.Lighting == input.Lighting ||
                    (this.Lighting != null &&
                    this.Lighting.Equals(input.Lighting))
                ) && 
                (
                    this.ElectricEquipment == input.ElectricEquipment ||
                    (this.ElectricEquipment != null &&
                    this.ElectricEquipment.Equals(input.ElectricEquipment))
                ) && 
                (
                    this.GasEquipment == input.GasEquipment ||
                    (this.GasEquipment != null &&
                    this.GasEquipment.Equals(input.GasEquipment))
                ) && 
                (
                    this.Infiltration == input.Infiltration ||
                    (this.Infiltration != null &&
                    this.Infiltration.Equals(input.Infiltration))
                ) && 
                (
                    this.Ventilation == input.Ventilation ||
                    (this.Ventilation != null &&
                    this.Ventilation.Equals(input.Ventilation))
                ) && 
                (
                    this.Setpoint == input.Setpoint ||
                    (this.Setpoint != null &&
                    this.Setpoint.Equals(input.Setpoint))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ConstructionSet != null)
                    hashCode = hashCode * 59 + this.ConstructionSet.GetHashCode();
                if (this.ProgramType != null)
                    hashCode = hashCode * 59 + this.ProgramType.GetHashCode();
                if (this.Hvac != null)
                    hashCode = hashCode * 59 + this.Hvac.GetHashCode();
                if (this.People != null)
                    hashCode = hashCode * 59 + this.People.GetHashCode();
                if (this.Lighting != null)
                    hashCode = hashCode * 59 + this.Lighting.GetHashCode();
                if (this.ElectricEquipment != null)
                    hashCode = hashCode * 59 + this.ElectricEquipment.GetHashCode();
                if (this.GasEquipment != null)
                    hashCode = hashCode * 59 + this.GasEquipment.GetHashCode();
                if (this.Infiltration != null)
                    hashCode = hashCode * 59 + this.Infiltration.GetHashCode();
                if (this.Ventilation != null)
                    hashCode = hashCode * 59 + this.Ventilation.GetHashCode();
                if (this.Setpoint != null)
                    hashCode = hashCode * 59 + this.Setpoint.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^RoomEnergyPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ConstructionSet (string) maxLength
            if(this.ConstructionSet != null && this.ConstructionSet.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConstructionSet, length must be less than 100.", new [] { "ConstructionSet" });
            }

            // ConstructionSet (string) minLength
            if(this.ConstructionSet != null && this.ConstructionSet.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConstructionSet, length must be greater than 1.", new [] { "ConstructionSet" });
            }

            // ProgramType (string) maxLength
            if(this.ProgramType != null && this.ProgramType.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramType, length must be less than 100.", new [] { "ProgramType" });
            }

            // ProgramType (string) minLength
            if(this.ProgramType != null && this.ProgramType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramType, length must be greater than 1.", new [] { "ProgramType" });
            }

            // Hvac (string) maxLength
            if(this.Hvac != null && this.Hvac.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hvac, length must be less than 100.", new [] { "Hvac" });
            }

            // Hvac (string) minLength
            if(this.Hvac != null && this.Hvac.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hvac, length must be greater than 1.", new [] { "Hvac" });
            }

            yield break;
        }
    }

}
