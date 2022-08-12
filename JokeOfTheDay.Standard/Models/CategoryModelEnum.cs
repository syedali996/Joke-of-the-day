// <copyright file="CategoryModelEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace JokeOfTheDay.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using JokeOfTheDay.Standard;
    using JokeOfTheDay.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CategoryModelEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryModelEnum
    {
        /// <summary>
        ///First category
        /// Category1.
        /// </summary>
        [EnumMember(Value = "animal")]
        Category1,

        /// <summary>
        ///second model
        /// Category2.
        /// </summary>
        [EnumMember(Value = "jod")]
        Category2,

        /// <summary>
        ///Third category
        /// Category3.
        /// </summary>
        [EnumMember(Value = "blonde")]
        Category3,

        /// <summary>
        ///fourth category
        /// Category4.
        /// </summary>
        [EnumMember(Value = "knock-knock")]
        Category4
    }
}