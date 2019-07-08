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
    /// A product dimension
    /// </summary>
    [DataContract]
    public partial class ProductDimension :  IEquatable<ProductDimension>, IValidatableObject
    {
        /// <summary>
        /// The type of this dimension
        /// </summary>
        /// <value>The type of this dimension</value>
        public enum DimensionTypeEnum
        {
            
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            
            NUMBER_0 = 0,
            
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            
            NUMBER_1 = 1,
            
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            
            NUMBER_2 = 2,
            
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            
            NUMBER_3 = 3,
            
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            
            NUMBER_4 = 4,
            
            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            
            NUMBER_5 = 5,
            
            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            
            NUMBER_6 = 6,
            
            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            
            NUMBER_7 = 7,
            
            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            
            NUMBER_8 = 8
        }

        /// <summary>
        /// The type of this dimension
        /// </summary>
        /// <value>The type of this dimension</value>
        [DataMember(Name="dimensionType", EmitDefaultValue=false)]
        public DimensionTypeEnum? DimensionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDimension" /> class.
        /// </summary>
        /// <param name="dimensionValue">The value of this dimension.</param>
        /// <param name="dimensionType">The type of this dimension.</param>
        public ProductDimension(double? dimensionValue = default(double?), DimensionTypeEnum? dimensionType = default(DimensionTypeEnum?))
        {
            this.DimensionValue = dimensionValue;
            this.DimensionType = dimensionType;
        }
        
        /// <summary>
        /// The value of this dimension
        /// </summary>
        /// <value>The value of this dimension</value>
        [DataMember(Name="dimensionValue", EmitDefaultValue=false)]
        public double? DimensionValue { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductDimension {\n");
            sb.Append("  DimensionValue: ").Append(DimensionValue).Append("\n");
            sb.Append("  DimensionType: ").Append(DimensionType).Append("\n");
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
            return this.Equals(input as ProductDimension);
        }

        /// <summary>
        /// Returns true if ProductDimension instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductDimension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductDimension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DimensionValue == input.DimensionValue ||
                    (this.DimensionValue != null &&
                    this.DimensionValue.Equals(input.DimensionValue))
                ) && 
                (
                    this.DimensionType == input.DimensionType ||
                    (this.DimensionType != null &&
                    this.DimensionType.Equals(input.DimensionType))
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
                if (this.DimensionValue != null)
                    hashCode = hashCode * 59 + this.DimensionValue.GetHashCode();
                if (this.DimensionType != null)
                    hashCode = hashCode * 59 + this.DimensionType.GetHashCode();
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
            yield break;
        }
    }

}
