/* 
 * Madaster Private API
 *
 * The Madaster Private API endpoint.
 *
 * OpenAPI spec version: 1.1
 * Contact: service@madaster.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = Madaster.API.Client.SwaggerDateConverter;

namespace Madaster.API.Model
{
    /// <summary>
    /// The circular properties of the element
    /// </summary>
    [DataContract]
    public partial class MaterialCircularInformation :  IEquatable<MaterialCircularInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialCircularInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MaterialCircularInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialCircularInformation" /> class.
        /// </summary>
        /// <param name="recycledPercentageFeedstock">The percentage of the material&#39;s feedstock that comes from recycled sources (required).</param>
        /// <param name="rapidRenewablesPercentageFeedstock">The percentage of the material&#39;s feedstock that comes from rapidly renewable sources (required).</param>
        /// <param name="recycledPercentageEndOfLife">The percentage of the material that can be recycled at its end of life (required).</param>
        /// <param name="landfillPercentageEndOfLife">The percentage of the material that will go to the landfill at its end of life (required).</param>
        /// <param name="efficiencyPercentageRecyclingFeedstock">The efficiency of the recycling process that led to the feedstock (required).</param>
        /// <param name="efficiencyPercentageRecyclingEndOfLife">The efficiency of the recycling process when the material reaches its end of life (required).</param>
        public MaterialCircularInformation(double? recycledPercentageFeedstock = default(double?), double? rapidRenewablesPercentageFeedstock = default(double?), double? recycledPercentageEndOfLife = default(double?), double? landfillPercentageEndOfLife = default(double?), double? efficiencyPercentageRecyclingFeedstock = default(double?), double? efficiencyPercentageRecyclingEndOfLife = default(double?))
        {
            // to ensure "recycledPercentageFeedstock" is required (not null)
            if (recycledPercentageFeedstock == null)
            {
                throw new InvalidDataException("recycledPercentageFeedstock is a required property for MaterialCircularInformation and cannot be null");
            }
            else
            {
                this.RecycledPercentageFeedstock = recycledPercentageFeedstock;
            }
            // to ensure "rapidRenewablesPercentageFeedstock" is required (not null)
            if (rapidRenewablesPercentageFeedstock == null)
            {
                throw new InvalidDataException("rapidRenewablesPercentageFeedstock is a required property for MaterialCircularInformation and cannot be null");
            }
            else
            {
                this.RapidRenewablesPercentageFeedstock = rapidRenewablesPercentageFeedstock;
            }
            // to ensure "recycledPercentageEndOfLife" is required (not null)
            if (recycledPercentageEndOfLife == null)
            {
                throw new InvalidDataException("recycledPercentageEndOfLife is a required property for MaterialCircularInformation and cannot be null");
            }
            else
            {
                this.RecycledPercentageEndOfLife = recycledPercentageEndOfLife;
            }
            // to ensure "landfillPercentageEndOfLife" is required (not null)
            if (landfillPercentageEndOfLife == null)
            {
                throw new InvalidDataException("landfillPercentageEndOfLife is a required property for MaterialCircularInformation and cannot be null");
            }
            else
            {
                this.LandfillPercentageEndOfLife = landfillPercentageEndOfLife;
            }
            // to ensure "efficiencyPercentageRecyclingFeedstock" is required (not null)
            if (efficiencyPercentageRecyclingFeedstock == null)
            {
                throw new InvalidDataException("efficiencyPercentageRecyclingFeedstock is a required property for MaterialCircularInformation and cannot be null");
            }
            else
            {
                this.EfficiencyPercentageRecyclingFeedstock = efficiencyPercentageRecyclingFeedstock;
            }
            // to ensure "efficiencyPercentageRecyclingEndOfLife" is required (not null)
            if (efficiencyPercentageRecyclingEndOfLife == null)
            {
                throw new InvalidDataException("efficiencyPercentageRecyclingEndOfLife is a required property for MaterialCircularInformation and cannot be null");
            }
            else
            {
                this.EfficiencyPercentageRecyclingEndOfLife = efficiencyPercentageRecyclingEndOfLife;
            }
        }
        
        /// <summary>
        /// The percentage of the material&#39;s feedstock that comes from recycled sources
        /// </summary>
        /// <value>The percentage of the material&#39;s feedstock that comes from recycled sources</value>
        [DataMember(Name="recycledPercentageFeedstock", EmitDefaultValue=false)]
        public double? RecycledPercentageFeedstock { get; set; }

        /// <summary>
        /// The percentage of the material&#39;s feedstock that comes from rapidly renewable sources
        /// </summary>
        /// <value>The percentage of the material&#39;s feedstock that comes from rapidly renewable sources</value>
        [DataMember(Name="rapidRenewablesPercentageFeedstock", EmitDefaultValue=false)]
        public double? RapidRenewablesPercentageFeedstock { get; set; }

        /// <summary>
        /// The percentage of the material&#39;s feedstock that comes from virgin sources
        /// </summary>
        /// <value>The percentage of the material&#39;s feedstock that comes from virgin sources</value>
        [DataMember(Name="virginPercentageFeedstock", EmitDefaultValue=false)]
        public double? VirginPercentageFeedstock { get; private set; }

        /// <summary>
        /// The percentage of the material that can be recycled at its end of life
        /// </summary>
        /// <value>The percentage of the material that can be recycled at its end of life</value>
        [DataMember(Name="recycledPercentageEndOfLife", EmitDefaultValue=false)]
        public double? RecycledPercentageEndOfLife { get; set; }

        /// <summary>
        /// The percentage of the material that will go to the landfill at its end of life
        /// </summary>
        /// <value>The percentage of the material that will go to the landfill at its end of life</value>
        [DataMember(Name="landfillPercentageEndOfLife", EmitDefaultValue=false)]
        public double? LandfillPercentageEndOfLife { get; set; }

        /// <summary>
        /// The percentage of the material that will be incinerated at its end of life
        /// </summary>
        /// <value>The percentage of the material that will be incinerated at its end of life</value>
        [DataMember(Name="incinerationPercentageEndOfLife", EmitDefaultValue=false)]
        public double? IncinerationPercentageEndOfLife { get; private set; }

        /// <summary>
        /// The efficiency of the recycling process that led to the feedstock
        /// </summary>
        /// <value>The efficiency of the recycling process that led to the feedstock</value>
        [DataMember(Name="efficiencyPercentageRecyclingFeedstock", EmitDefaultValue=false)]
        public double? EfficiencyPercentageRecyclingFeedstock { get; set; }

        /// <summary>
        /// The efficiency of the recycling process when the material reaches its end of life
        /// </summary>
        /// <value>The efficiency of the recycling process when the material reaches its end of life</value>
        [DataMember(Name="efficiencyPercentageRecyclingEndOfLife", EmitDefaultValue=false)]
        public double? EfficiencyPercentageRecyclingEndOfLife { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaterialCircularInformation {\n");
            sb.Append("  RecycledPercentageFeedstock: ").Append(RecycledPercentageFeedstock).Append("\n");
            sb.Append("  RapidRenewablesPercentageFeedstock: ").Append(RapidRenewablesPercentageFeedstock).Append("\n");
            sb.Append("  VirginPercentageFeedstock: ").Append(VirginPercentageFeedstock).Append("\n");
            sb.Append("  RecycledPercentageEndOfLife: ").Append(RecycledPercentageEndOfLife).Append("\n");
            sb.Append("  LandfillPercentageEndOfLife: ").Append(LandfillPercentageEndOfLife).Append("\n");
            sb.Append("  IncinerationPercentageEndOfLife: ").Append(IncinerationPercentageEndOfLife).Append("\n");
            sb.Append("  EfficiencyPercentageRecyclingFeedstock: ").Append(EfficiencyPercentageRecyclingFeedstock).Append("\n");
            sb.Append("  EfficiencyPercentageRecyclingEndOfLife: ").Append(EfficiencyPercentageRecyclingEndOfLife).Append("\n");
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
            return this.Equals(input as MaterialCircularInformation);
        }

        /// <summary>
        /// Returns true if MaterialCircularInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of MaterialCircularInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaterialCircularInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecycledPercentageFeedstock == input.RecycledPercentageFeedstock ||
                    (this.RecycledPercentageFeedstock != null &&
                    this.RecycledPercentageFeedstock.Equals(input.RecycledPercentageFeedstock))
                ) && 
                (
                    this.RapidRenewablesPercentageFeedstock == input.RapidRenewablesPercentageFeedstock ||
                    (this.RapidRenewablesPercentageFeedstock != null &&
                    this.RapidRenewablesPercentageFeedstock.Equals(input.RapidRenewablesPercentageFeedstock))
                ) && 
                (
                    this.VirginPercentageFeedstock == input.VirginPercentageFeedstock ||
                    (this.VirginPercentageFeedstock != null &&
                    this.VirginPercentageFeedstock.Equals(input.VirginPercentageFeedstock))
                ) && 
                (
                    this.RecycledPercentageEndOfLife == input.RecycledPercentageEndOfLife ||
                    (this.RecycledPercentageEndOfLife != null &&
                    this.RecycledPercentageEndOfLife.Equals(input.RecycledPercentageEndOfLife))
                ) && 
                (
                    this.LandfillPercentageEndOfLife == input.LandfillPercentageEndOfLife ||
                    (this.LandfillPercentageEndOfLife != null &&
                    this.LandfillPercentageEndOfLife.Equals(input.LandfillPercentageEndOfLife))
                ) && 
                (
                    this.IncinerationPercentageEndOfLife == input.IncinerationPercentageEndOfLife ||
                    (this.IncinerationPercentageEndOfLife != null &&
                    this.IncinerationPercentageEndOfLife.Equals(input.IncinerationPercentageEndOfLife))
                ) && 
                (
                    this.EfficiencyPercentageRecyclingFeedstock == input.EfficiencyPercentageRecyclingFeedstock ||
                    (this.EfficiencyPercentageRecyclingFeedstock != null &&
                    this.EfficiencyPercentageRecyclingFeedstock.Equals(input.EfficiencyPercentageRecyclingFeedstock))
                ) && 
                (
                    this.EfficiencyPercentageRecyclingEndOfLife == input.EfficiencyPercentageRecyclingEndOfLife ||
                    (this.EfficiencyPercentageRecyclingEndOfLife != null &&
                    this.EfficiencyPercentageRecyclingEndOfLife.Equals(input.EfficiencyPercentageRecyclingEndOfLife))
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
                if (this.RecycledPercentageFeedstock != null)
                    hashCode = hashCode * 59 + this.RecycledPercentageFeedstock.GetHashCode();
                if (this.RapidRenewablesPercentageFeedstock != null)
                    hashCode = hashCode * 59 + this.RapidRenewablesPercentageFeedstock.GetHashCode();
                if (this.VirginPercentageFeedstock != null)
                    hashCode = hashCode * 59 + this.VirginPercentageFeedstock.GetHashCode();
                if (this.RecycledPercentageEndOfLife != null)
                    hashCode = hashCode * 59 + this.RecycledPercentageEndOfLife.GetHashCode();
                if (this.LandfillPercentageEndOfLife != null)
                    hashCode = hashCode * 59 + this.LandfillPercentageEndOfLife.GetHashCode();
                if (this.IncinerationPercentageEndOfLife != null)
                    hashCode = hashCode * 59 + this.IncinerationPercentageEndOfLife.GetHashCode();
                if (this.EfficiencyPercentageRecyclingFeedstock != null)
                    hashCode = hashCode * 59 + this.EfficiencyPercentageRecyclingFeedstock.GetHashCode();
                if (this.EfficiencyPercentageRecyclingEndOfLife != null)
                    hashCode = hashCode * 59 + this.EfficiencyPercentageRecyclingEndOfLife.GetHashCode();
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
            // RecycledPercentageFeedstock (double?) maximum
            if(this.RecycledPercentageFeedstock > (double?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecycledPercentageFeedstock, must be a value less than or equal to 1.", new [] { "RecycledPercentageFeedstock" });
            }

            // RecycledPercentageFeedstock (double?) minimum
            if(this.RecycledPercentageFeedstock < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecycledPercentageFeedstock, must be a value greater than or equal to 0.", new [] { "RecycledPercentageFeedstock" });
            }

            // RapidRenewablesPercentageFeedstock (double?) maximum
            if(this.RapidRenewablesPercentageFeedstock > (double?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RapidRenewablesPercentageFeedstock, must be a value less than or equal to 1.", new [] { "RapidRenewablesPercentageFeedstock" });
            }

            // RapidRenewablesPercentageFeedstock (double?) minimum
            if(this.RapidRenewablesPercentageFeedstock < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RapidRenewablesPercentageFeedstock, must be a value greater than or equal to 0.", new [] { "RapidRenewablesPercentageFeedstock" });
            }

            // RecycledPercentageEndOfLife (double?) maximum
            if(this.RecycledPercentageEndOfLife > (double?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecycledPercentageEndOfLife, must be a value less than or equal to 1.", new [] { "RecycledPercentageEndOfLife" });
            }

            // RecycledPercentageEndOfLife (double?) minimum
            if(this.RecycledPercentageEndOfLife < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RecycledPercentageEndOfLife, must be a value greater than or equal to 0.", new [] { "RecycledPercentageEndOfLife" });
            }

            // LandfillPercentageEndOfLife (double?) maximum
            if(this.LandfillPercentageEndOfLife > (double?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LandfillPercentageEndOfLife, must be a value less than or equal to 1.", new [] { "LandfillPercentageEndOfLife" });
            }

            // LandfillPercentageEndOfLife (double?) minimum
            if(this.LandfillPercentageEndOfLife < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LandfillPercentageEndOfLife, must be a value greater than or equal to 0.", new [] { "LandfillPercentageEndOfLife" });
            }

            // EfficiencyPercentageRecyclingFeedstock (double?) maximum
            if(this.EfficiencyPercentageRecyclingFeedstock > (double?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EfficiencyPercentageRecyclingFeedstock, must be a value less than or equal to 1.", new [] { "EfficiencyPercentageRecyclingFeedstock" });
            }

            // EfficiencyPercentageRecyclingFeedstock (double?) minimum
            if(this.EfficiencyPercentageRecyclingFeedstock < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EfficiencyPercentageRecyclingFeedstock, must be a value greater than or equal to 0.", new [] { "EfficiencyPercentageRecyclingFeedstock" });
            }

            // EfficiencyPercentageRecyclingEndOfLife (double?) maximum
            if(this.EfficiencyPercentageRecyclingEndOfLife > (double?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EfficiencyPercentageRecyclingEndOfLife, must be a value less than or equal to 1.", new [] { "EfficiencyPercentageRecyclingEndOfLife" });
            }

            // EfficiencyPercentageRecyclingEndOfLife (double?) minimum
            if(this.EfficiencyPercentageRecyclingEndOfLife < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EfficiencyPercentageRecyclingEndOfLife, must be a value greater than or equal to 0.", new [] { "EfficiencyPercentageRecyclingEndOfLife" });
            }

            yield break;
        }
    }

}
