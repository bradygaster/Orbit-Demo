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
    /// cat_OriginalCreatedByUser
    /// </summary>
    [DataContract]
    public partial class InlineResponseDefaultCatOriginalCreatedByUser : IEquatable<InlineResponseDefaultCatOriginalCreatedByUser>
    { 
        /// <summary>
        /// fullname
        /// </summary>
        /// <value>fullname</value>
        [DataMember(Name="fullname")]
        public string Fullname { get; set; }

        /// <summary>
        /// firstname
        /// </summary>
        /// <value>firstname</value>
        [DataMember(Name="firstname")]
        public string Firstname { get; set; }

        /// <summary>
        /// lastname
        /// </summary>
        /// <value>lastname</value>
        [DataMember(Name="lastname")]
        public string Lastname { get; set; }

        /// <summary>
        /// nickname
        /// </summary>
        /// <value>nickname</value>
        [DataMember(Name="nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// systemuserid
        /// </summary>
        /// <value>systemuserid</value>
        [DataMember(Name="systemuserid")]
        public string Systemuserid { get; set; }

        /// <summary>
        /// ownerid
        /// </summary>
        /// <value>ownerid</value>
        [DataMember(Name="ownerid")]
        public string Ownerid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefaultCatOriginalCreatedByUser {\n");
            sb.Append("  Fullname: ").Append(Fullname).Append("\n");
            sb.Append("  Firstname: ").Append(Firstname).Append("\n");
            sb.Append("  Lastname: ").Append(Lastname).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Systemuserid: ").Append(Systemuserid).Append("\n");
            sb.Append("  Ownerid: ").Append(Ownerid).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponseDefaultCatOriginalCreatedByUser)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefaultCatOriginalCreatedByUser instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefaultCatOriginalCreatedByUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefaultCatOriginalCreatedByUser other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Fullname == other.Fullname ||
                    Fullname != null &&
                    Fullname.Equals(other.Fullname)
                ) && 
                (
                    Firstname == other.Firstname ||
                    Firstname != null &&
                    Firstname.Equals(other.Firstname)
                ) && 
                (
                    Lastname == other.Lastname ||
                    Lastname != null &&
                    Lastname.Equals(other.Lastname)
                ) && 
                (
                    Nickname == other.Nickname ||
                    Nickname != null &&
                    Nickname.Equals(other.Nickname)
                ) && 
                (
                    Systemuserid == other.Systemuserid ||
                    Systemuserid != null &&
                    Systemuserid.Equals(other.Systemuserid)
                ) && 
                (
                    Ownerid == other.Ownerid ||
                    Ownerid != null &&
                    Ownerid.Equals(other.Ownerid)
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
                    if (Fullname != null)
                    hashCode = hashCode * 59 + Fullname.GetHashCode();
                    if (Firstname != null)
                    hashCode = hashCode * 59 + Firstname.GetHashCode();
                    if (Lastname != null)
                    hashCode = hashCode * 59 + Lastname.GetHashCode();
                    if (Nickname != null)
                    hashCode = hashCode * 59 + Nickname.GetHashCode();
                    if (Systemuserid != null)
                    hashCode = hashCode * 59 + Systemuserid.GetHashCode();
                    if (Ownerid != null)
                    hashCode = hashCode * 59 + Ownerid.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefaultCatOriginalCreatedByUser left, InlineResponseDefaultCatOriginalCreatedByUser right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefaultCatOriginalCreatedByUser left, InlineResponseDefaultCatOriginalCreatedByUser right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
