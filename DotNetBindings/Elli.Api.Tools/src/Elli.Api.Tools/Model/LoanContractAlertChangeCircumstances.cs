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
 * Tools
 *
 * Represents calculations applied on a loan
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
using SwaggerDateConverter = Elli.Api.Tools.Client.SwaggerDateConverter;

namespace Elli.Api.Tools.Model
{
    /// <summary>
    /// LoanContractAlertChangeCircumstances
    /// </summary>
    [DataContract]
    public partial class LoanContractAlertChangeCircumstances :  IEquatable<LoanContractAlertChangeCircumstances>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AlertTriggerFielDID
        /// </summary>
        [DataMember(Name="alertTriggerFielDID", EmitDefaultValue=false)]
        public string AlertTriggerFielDID { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceDate
        /// </summary>
        [DataMember(Name="changedCircumstanceDate", EmitDefaultValue=false)]
        public DateTime? ChangedCircumstanceDate { get; set; }

        /// <summary>
        /// Gets or Sets RevisedDueDate
        /// </summary>
        [DataMember(Name="revisedDueDate", EmitDefaultValue=false)]
        public DateTime? RevisedDueDate { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceDescription
        /// </summary>
        [DataMember(Name="changedCircumstanceDescription", EmitDefaultValue=false)]
        public string ChangedCircumstanceDescription { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceComments
        /// </summary>
        [DataMember(Name="changedCircumstanceComments", EmitDefaultValue=false)]
        public string ChangedCircumstanceComments { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceReason
        /// </summary>
        [DataMember(Name="changedCircumstanceReason", EmitDefaultValue=false)]
        public string ChangedCircumstanceReason { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceReasonOther
        /// </summary>
        [DataMember(Name="changedCircumstanceReasonOther", EmitDefaultValue=false)]
        public string ChangedCircumstanceReasonOther { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceCategory
        /// </summary>
        [DataMember(Name="changedCircumstanceCategory", EmitDefaultValue=false)]
        public string ChangedCircumstanceCategory { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceAlertFeeDescription
        /// </summary>
        [DataMember(Name="changedCircumstanceAlertFeeDescription", EmitDefaultValue=false)]
        public string ChangedCircumstanceAlertFeeDescription { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceAlertInitialAmount
        /// </summary>
        [DataMember(Name="changedCircumstanceAlertInitialAmount", EmitDefaultValue=false)]
        public double? ChangedCircumstanceAlertInitialAmount { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceAlertBaseline
        /// </summary>
        [DataMember(Name="changedCircumstanceAlertBaseline", EmitDefaultValue=false)]
        public string ChangedCircumstanceAlertBaseline { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceAlertDisclosedAmount
        /// </summary>
        [DataMember(Name="changedCircumstanceAlertDisclosedAmount", EmitDefaultValue=false)]
        public double? ChangedCircumstanceAlertDisclosedAmount { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceAlertItemizationAmount
        /// </summary>
        [DataMember(Name="changedCircumstanceAlertItemizationAmount", EmitDefaultValue=false)]
        public double? ChangedCircumstanceAlertItemizationAmount { get; set; }

        /// <summary>
        /// Gets or Sets ChangedCircumstanceAlertVarianceAmount
        /// </summary>
        [DataMember(Name="changedCircumstanceAlertVarianceAmount", EmitDefaultValue=false)]
        public double? ChangedCircumstanceAlertVarianceAmount { get; set; }

        /// <summary>
        /// Gets or Sets AltId
        /// </summary>
        [DataMember(Name="altId", EmitDefaultValue=false)]
        public string AltId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractAlertChangeCircumstances {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AlertTriggerFielDID: ").Append(AlertTriggerFielDID).Append("\n");
            sb.Append("  ChangedCircumstanceDate: ").Append(ChangedCircumstanceDate).Append("\n");
            sb.Append("  RevisedDueDate: ").Append(RevisedDueDate).Append("\n");
            sb.Append("  ChangedCircumstanceDescription: ").Append(ChangedCircumstanceDescription).Append("\n");
            sb.Append("  ChangedCircumstanceComments: ").Append(ChangedCircumstanceComments).Append("\n");
            sb.Append("  ChangedCircumstanceReason: ").Append(ChangedCircumstanceReason).Append("\n");
            sb.Append("  ChangedCircumstanceReasonOther: ").Append(ChangedCircumstanceReasonOther).Append("\n");
            sb.Append("  ChangedCircumstanceCategory: ").Append(ChangedCircumstanceCategory).Append("\n");
            sb.Append("  ChangedCircumstanceAlertFeeDescription: ").Append(ChangedCircumstanceAlertFeeDescription).Append("\n");
            sb.Append("  ChangedCircumstanceAlertInitialAmount: ").Append(ChangedCircumstanceAlertInitialAmount).Append("\n");
            sb.Append("  ChangedCircumstanceAlertBaseline: ").Append(ChangedCircumstanceAlertBaseline).Append("\n");
            sb.Append("  ChangedCircumstanceAlertDisclosedAmount: ").Append(ChangedCircumstanceAlertDisclosedAmount).Append("\n");
            sb.Append("  ChangedCircumstanceAlertItemizationAmount: ").Append(ChangedCircumstanceAlertItemizationAmount).Append("\n");
            sb.Append("  ChangedCircumstanceAlertVarianceAmount: ").Append(ChangedCircumstanceAlertVarianceAmount).Append("\n");
            sb.Append("  AltId: ").Append(AltId).Append("\n");
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
            return this.Equals(input as LoanContractAlertChangeCircumstances);
        }

        /// <summary>
        /// Returns true if LoanContractAlertChangeCircumstances instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractAlertChangeCircumstances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractAlertChangeCircumstances input)
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
                    this.AlertTriggerFielDID == input.AlertTriggerFielDID ||
                    (this.AlertTriggerFielDID != null &&
                    this.AlertTriggerFielDID.Equals(input.AlertTriggerFielDID))
                ) && 
                (
                    this.ChangedCircumstanceDate == input.ChangedCircumstanceDate ||
                    (this.ChangedCircumstanceDate != null &&
                    this.ChangedCircumstanceDate.Equals(input.ChangedCircumstanceDate))
                ) && 
                (
                    this.RevisedDueDate == input.RevisedDueDate ||
                    (this.RevisedDueDate != null &&
                    this.RevisedDueDate.Equals(input.RevisedDueDate))
                ) && 
                (
                    this.ChangedCircumstanceDescription == input.ChangedCircumstanceDescription ||
                    (this.ChangedCircumstanceDescription != null &&
                    this.ChangedCircumstanceDescription.Equals(input.ChangedCircumstanceDescription))
                ) && 
                (
                    this.ChangedCircumstanceComments == input.ChangedCircumstanceComments ||
                    (this.ChangedCircumstanceComments != null &&
                    this.ChangedCircumstanceComments.Equals(input.ChangedCircumstanceComments))
                ) && 
                (
                    this.ChangedCircumstanceReason == input.ChangedCircumstanceReason ||
                    (this.ChangedCircumstanceReason != null &&
                    this.ChangedCircumstanceReason.Equals(input.ChangedCircumstanceReason))
                ) && 
                (
                    this.ChangedCircumstanceReasonOther == input.ChangedCircumstanceReasonOther ||
                    (this.ChangedCircumstanceReasonOther != null &&
                    this.ChangedCircumstanceReasonOther.Equals(input.ChangedCircumstanceReasonOther))
                ) && 
                (
                    this.ChangedCircumstanceCategory == input.ChangedCircumstanceCategory ||
                    (this.ChangedCircumstanceCategory != null &&
                    this.ChangedCircumstanceCategory.Equals(input.ChangedCircumstanceCategory))
                ) && 
                (
                    this.ChangedCircumstanceAlertFeeDescription == input.ChangedCircumstanceAlertFeeDescription ||
                    (this.ChangedCircumstanceAlertFeeDescription != null &&
                    this.ChangedCircumstanceAlertFeeDescription.Equals(input.ChangedCircumstanceAlertFeeDescription))
                ) && 
                (
                    this.ChangedCircumstanceAlertInitialAmount == input.ChangedCircumstanceAlertInitialAmount ||
                    (this.ChangedCircumstanceAlertInitialAmount != null &&
                    this.ChangedCircumstanceAlertInitialAmount.Equals(input.ChangedCircumstanceAlertInitialAmount))
                ) && 
                (
                    this.ChangedCircumstanceAlertBaseline == input.ChangedCircumstanceAlertBaseline ||
                    (this.ChangedCircumstanceAlertBaseline != null &&
                    this.ChangedCircumstanceAlertBaseline.Equals(input.ChangedCircumstanceAlertBaseline))
                ) && 
                (
                    this.ChangedCircumstanceAlertDisclosedAmount == input.ChangedCircumstanceAlertDisclosedAmount ||
                    (this.ChangedCircumstanceAlertDisclosedAmount != null &&
                    this.ChangedCircumstanceAlertDisclosedAmount.Equals(input.ChangedCircumstanceAlertDisclosedAmount))
                ) && 
                (
                    this.ChangedCircumstanceAlertItemizationAmount == input.ChangedCircumstanceAlertItemizationAmount ||
                    (this.ChangedCircumstanceAlertItemizationAmount != null &&
                    this.ChangedCircumstanceAlertItemizationAmount.Equals(input.ChangedCircumstanceAlertItemizationAmount))
                ) && 
                (
                    this.ChangedCircumstanceAlertVarianceAmount == input.ChangedCircumstanceAlertVarianceAmount ||
                    (this.ChangedCircumstanceAlertVarianceAmount != null &&
                    this.ChangedCircumstanceAlertVarianceAmount.Equals(input.ChangedCircumstanceAlertVarianceAmount))
                ) && 
                (
                    this.AltId == input.AltId ||
                    (this.AltId != null &&
                    this.AltId.Equals(input.AltId))
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
                if (this.AlertTriggerFielDID != null)
                    hashCode = hashCode * 59 + this.AlertTriggerFielDID.GetHashCode();
                if (this.ChangedCircumstanceDate != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceDate.GetHashCode();
                if (this.RevisedDueDate != null)
                    hashCode = hashCode * 59 + this.RevisedDueDate.GetHashCode();
                if (this.ChangedCircumstanceDescription != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceDescription.GetHashCode();
                if (this.ChangedCircumstanceComments != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceComments.GetHashCode();
                if (this.ChangedCircumstanceReason != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceReason.GetHashCode();
                if (this.ChangedCircumstanceReasonOther != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceReasonOther.GetHashCode();
                if (this.ChangedCircumstanceCategory != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceCategory.GetHashCode();
                if (this.ChangedCircumstanceAlertFeeDescription != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceAlertFeeDescription.GetHashCode();
                if (this.ChangedCircumstanceAlertInitialAmount != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceAlertInitialAmount.GetHashCode();
                if (this.ChangedCircumstanceAlertBaseline != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceAlertBaseline.GetHashCode();
                if (this.ChangedCircumstanceAlertDisclosedAmount != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceAlertDisclosedAmount.GetHashCode();
                if (this.ChangedCircumstanceAlertItemizationAmount != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceAlertItemizationAmount.GetHashCode();
                if (this.ChangedCircumstanceAlertVarianceAmount != null)
                    hashCode = hashCode * 59 + this.ChangedCircumstanceAlertVarianceAmount.GetHashCode();
                if (this.AltId != null)
                    hashCode = hashCode * 59 + this.AltId.GetHashCode();
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
