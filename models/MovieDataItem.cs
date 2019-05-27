/*
 * Movie API Specification
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0
 * Contact: juliuscanute@touchcapture.net
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

namespace MovieApi.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class MovieDataItem : IEquatable<MovieDataItem>
    { 
        /// <summary>
        /// Title of the movie
        /// </summary>
        /// <value>Title of the movie</value>
        [DataMember(Name="title")]
        public string Title { get; set; }

        /// <summary>
        /// Release year of the movie
        /// </summary>
        /// <value>Release year of the movie</value>
        [DataMember(Name="year")]
        public string Year { get; set; }

        /// <summary>
        /// Image location of the URI
        /// </summary>
        /// <value>Image location of the URI</value>
        [DataMember(Name="poster")]
        public string Poster { get; set; }

        /// <summary>
        /// Best price for the movie
        /// </summary>
        /// <value>Best price for the movie</value>
        [DataMember(Name="bestPrice")]
        public decimal? BestPrice { get; set; }

        /// <summary>
        /// Gets or Sets Providers
        /// </summary>
        [DataMember(Name="providers")]
        public List<ProviderDataItem> Providers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MovieDataItem {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Poster: ").Append(Poster).Append("\n");
            sb.Append("  BestPrice: ").Append(BestPrice).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MovieDataItem)obj);
        }

        /// <summary>
        /// Returns true if MovieDataItem instances are equal
        /// </summary>
        /// <param name="other">Instance of MovieDataItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MovieDataItem other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    Year == other.Year ||
                    Year != null &&
                    Year.Equals(other.Year)
                ) && 
                (
                    Poster == other.Poster ||
                    Poster != null &&
                    Poster.Equals(other.Poster)
                ) && 
                (
                    BestPrice == other.BestPrice ||
                    BestPrice != null &&
                    BestPrice.Equals(other.BestPrice)
                ) && 
                (
                    Providers == other.Providers ||
                    Providers != null &&
                    Providers.SequenceEqual(other.Providers)
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
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (Year != null)
                    hashCode = hashCode * 59 + Year.GetHashCode();
                    if (Poster != null)
                    hashCode = hashCode * 59 + Poster.GetHashCode();
                    if (BestPrice != null)
                    hashCode = hashCode * 59 + BestPrice.GetHashCode();
                    if (Providers != null)
                    hashCode = hashCode * 59 + Providers.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MovieDataItem left, MovieDataItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MovieDataItem left, MovieDataItem right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
