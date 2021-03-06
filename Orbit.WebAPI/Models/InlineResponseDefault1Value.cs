/*
 * CDS - GtmEntries
 *
 * CDS - GtmEntries
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace APIMDemo.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponseDefault1Value : IEquatable<InlineResponseDefault1Value>
    { 
        /// <summary>
        /// @odata.etag
        /// </summary>
        /// <value>@odata.etag</value>
        [DataMember(Name="@odata.etag")]
        public string OdataEtag { get; set; }

        /// <summary>
        /// uniquename
        /// </summary>
        /// <value>uniquename</value>
        [DataMember(Name="uniquename")]
        public string Uniquename { get; set; }

        /// <summary>
        /// workflowid
        /// </summary>
        /// <value>workflowid</value>
        [DataMember(Name="workflowid")]
        public string Workflowid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefault1Value {\n");
            sb.Append("  OdataEtag: ").Append(OdataEtag).Append("\n");
            sb.Append("  Uniquename: ").Append(Uniquename).Append("\n");
            sb.Append("  Workflowid: ").Append(Workflowid).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponseDefault1Value)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefault1Value instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefault1Value to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefault1Value other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    OdataEtag == other.OdataEtag ||
                    OdataEtag != null &&
                    OdataEtag.Equals(other.OdataEtag)
                ) && 
                (
                    Uniquename == other.Uniquename ||
                    Uniquename != null &&
                    Uniquename.Equals(other.Uniquename)
                ) && 
                (
                    Workflowid == other.Workflowid ||
                    Workflowid != null &&
                    Workflowid.Equals(other.Workflowid)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (OdataEtag != null)
                    hashCode = hashCode * 59 + OdataEtag.GetHashCode();
                    if (Uniquename != null)
                    hashCode = hashCode * 59 + Uniquename.GetHashCode();
                    if (Workflowid != null)
                    hashCode = hashCode * 59 + Workflowid.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefault1Value left, InlineResponseDefault1Value right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefault1Value left, InlineResponseDefault1Value right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
