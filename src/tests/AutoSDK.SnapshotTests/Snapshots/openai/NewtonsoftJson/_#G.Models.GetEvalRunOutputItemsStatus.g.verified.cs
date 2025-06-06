﻿//HintName: G.Models.GetEvalRunOutputItemsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetEvalRunOutputItemsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fail")]
        Fail,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pass")]
        Pass,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetEvalRunOutputItemsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalRunOutputItemsStatus value)
        {
            return value switch
            {
                GetEvalRunOutputItemsStatus.Fail => "fail",
                GetEvalRunOutputItemsStatus.Pass => "pass",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalRunOutputItemsStatus? ToEnum(string value)
        {
            return value switch
            {
                "fail" => GetEvalRunOutputItemsStatus.Fail,
                "pass" => GetEvalRunOutputItemsStatus.Pass,
                _ => null,
            };
        }
    }
}