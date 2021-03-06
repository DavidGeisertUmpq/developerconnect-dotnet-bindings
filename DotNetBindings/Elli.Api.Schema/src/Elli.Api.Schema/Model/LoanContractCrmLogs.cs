/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Schema
 *
 * Represents schema operations on Loan.
 *
 * OpenAPI spec version: 1.4.1
 * 
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
using SwaggerDateConverter = Elli.Api.Schema.Client.SwaggerDateConverter;

namespace Elli.Api.Schema.Model
{
    /// <summary>
    /// LoanContractCrmLogs
    /// </summary>
    [DataContract]
    public partial class LoanContractCrmLogs :  IEquatable<LoanContractCrmLogs>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ContactGuid
        /// </summary>
        [DataMember(Name="contactGuid", EmitDefaultValue=false)]
        public string ContactGuid { get; set; }

        /// <summary>
        /// Gets or Sets MappingId
        /// </summary>
        [DataMember(Name="mappingId", EmitDefaultValue=false)]
        public string MappingId { get; set; }

        /// <summary>
        /// Gets or Sets MappingType
        /// </summary>
        [DataMember(Name="mappingType", EmitDefaultValue=false)]
        public int? MappingType { get; set; }

        /// <summary>
        /// Gets or Sets RoleType
        /// </summary>
        [DataMember(Name="roleType", EmitDefaultValue=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// Gets or Sets SystemId
        /// </summary>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public string SystemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractCrmLogs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContactGuid: ").Append(ContactGuid).Append("\n");
            sb.Append("  MappingId: ").Append(MappingId).Append("\n");
            sb.Append("  MappingType: ").Append(MappingType).Append("\n");
            sb.Append("  RoleType: ").Append(RoleType).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as LoanContractCrmLogs);
        }

        /// <summary>
        /// Returns true if LoanContractCrmLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractCrmLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractCrmLogs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ContactGuid == input.ContactGuid ||
                    (this.ContactGuid != null &&
                    this.ContactGuid.Equals(input.ContactGuid))
                ) && 
                (
                    this.MappingId == input.MappingId ||
                    (this.MappingId != null &&
                    this.MappingId.Equals(input.MappingId))
                ) && 
                (
                    this.MappingType == input.MappingType ||
                    (this.MappingType != null &&
                    this.MappingType.Equals(input.MappingType))
                ) && 
                (
                    this.RoleType == input.RoleType ||
                    (this.RoleType != null &&
                    this.RoleType.Equals(input.RoleType))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ContactGuid != null)
                    hashCode = hashCode * 59 + this.ContactGuid.GetHashCode();
                if (this.MappingId != null)
                    hashCode = hashCode * 59 + this.MappingId.GetHashCode();
                if (this.MappingType != null)
                    hashCode = hashCode * 59 + this.MappingType.GetHashCode();
                if (this.RoleType != null)
                    hashCode = hashCode * 59 + this.RoleType.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
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
