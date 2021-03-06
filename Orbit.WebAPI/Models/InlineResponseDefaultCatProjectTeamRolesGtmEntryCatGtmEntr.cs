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
    public partial class InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr : IEquatable<InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr>
    { 
        /// <summary>
        /// @odata.etag
        /// </summary>
        /// <value>@odata.etag</value>
        [DataMember(Name="@odata.etag")]
        public string OdataEtag { get; set; }

        /// <summary>
        /// _cat_teammember_value@OData.Community.Display.V1.FormattedValue
        /// </summary>
        /// <value>_cat_teammember_value@OData.Community.Display.V1.FormattedValue</value>
        [DataMember(Name="_cat_teammember_value@OData.Community.Display.V1.FormattedValue")]
        public string CatTeammemberValueODataCommunityDisplayV1FormattedValue { get; set; }

        /// <summary>
        /// _cat_teammember_value
        /// </summary>
        /// <value>_cat_teammember_value</value>
        [DataMember(Name="_cat_teammember_value")]
        public string CatTeammemberValue { get; set; }

        /// <summary>
        /// _cat_gtmentry_value@OData.Community.Display.V1.FormattedValue
        /// </summary>
        /// <value>_cat_gtmentry_value@OData.Community.Display.V1.FormattedValue</value>
        [DataMember(Name="_cat_gtmentry_value@OData.Community.Display.V1.FormattedValue")]
        public string CatGtmentryValueODataCommunityDisplayV1FormattedValue { get; set; }

        /// <summary>
        /// _cat_gtmentry_value
        /// </summary>
        /// <value>_cat_gtmentry_value</value>
        [DataMember(Name="_cat_gtmentry_value")]
        public string CatGtmentryValue { get; set; }

        /// <summary>
        /// cat_projectteamrolesid
        /// </summary>
        /// <value>cat_projectteamrolesid</value>
        [DataMember(Name="cat_projectteamrolesid")]
        public string CatProjectteamrolesid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr {\n");
            sb.Append("  OdataEtag: ").Append(OdataEtag).Append("\n");
            sb.Append("  CatTeammemberValueODataCommunityDisplayV1FormattedValue: ").Append(CatTeammemberValueODataCommunityDisplayV1FormattedValue).Append("\n");
            sb.Append("  CatTeammemberValue: ").Append(CatTeammemberValue).Append("\n");
            sb.Append("  CatGtmentryValueODataCommunityDisplayV1FormattedValue: ").Append(CatGtmentryValueODataCommunityDisplayV1FormattedValue).Append("\n");
            sb.Append("  CatGtmentryValue: ").Append(CatGtmentryValue).Append("\n");
            sb.Append("  CatProjectteamrolesid: ").Append(CatProjectteamrolesid).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr)obj);
        }

        /// <summary>
        /// Returns true if InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr other)
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
                    CatTeammemberValueODataCommunityDisplayV1FormattedValue == other.CatTeammemberValueODataCommunityDisplayV1FormattedValue ||
                    CatTeammemberValueODataCommunityDisplayV1FormattedValue != null &&
                    CatTeammemberValueODataCommunityDisplayV1FormattedValue.Equals(other.CatTeammemberValueODataCommunityDisplayV1FormattedValue)
                ) && 
                (
                    CatTeammemberValue == other.CatTeammemberValue ||
                    CatTeammemberValue != null &&
                    CatTeammemberValue.Equals(other.CatTeammemberValue)
                ) && 
                (
                    CatGtmentryValueODataCommunityDisplayV1FormattedValue == other.CatGtmentryValueODataCommunityDisplayV1FormattedValue ||
                    CatGtmentryValueODataCommunityDisplayV1FormattedValue != null &&
                    CatGtmentryValueODataCommunityDisplayV1FormattedValue.Equals(other.CatGtmentryValueODataCommunityDisplayV1FormattedValue)
                ) && 
                (
                    CatGtmentryValue == other.CatGtmentryValue ||
                    CatGtmentryValue != null &&
                    CatGtmentryValue.Equals(other.CatGtmentryValue)
                ) && 
                (
                    CatProjectteamrolesid == other.CatProjectteamrolesid ||
                    CatProjectteamrolesid != null &&
                    CatProjectteamrolesid.Equals(other.CatProjectteamrolesid)
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
                    if (CatTeammemberValueODataCommunityDisplayV1FormattedValue != null)
                    hashCode = hashCode * 59 + CatTeammemberValueODataCommunityDisplayV1FormattedValue.GetHashCode();
                    if (CatTeammemberValue != null)
                    hashCode = hashCode * 59 + CatTeammemberValue.GetHashCode();
                    if (CatGtmentryValueODataCommunityDisplayV1FormattedValue != null)
                    hashCode = hashCode * 59 + CatGtmentryValueODataCommunityDisplayV1FormattedValue.GetHashCode();
                    if (CatGtmentryValue != null)
                    hashCode = hashCode * 59 + CatGtmentryValue.GetHashCode();
                    if (CatProjectteamrolesid != null)
                    hashCode = hashCode * 59 + CatProjectteamrolesid.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr left, InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr left, InlineResponseDefaultCatProjectTeamRolesGtmEntryCatGtmEntr right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
