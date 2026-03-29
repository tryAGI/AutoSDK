//HintName: G.Models.ValidatorReferenceOnFail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action to take when validation fails.<br/>
    /// Default Value: noop
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ValidatorReferenceOnFail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exception")]
        Exception,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="filter")]
        Filter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fix")]
        Fix,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fix_reask")]
        FixReask,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="noop")]
        Noop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reask")]
        Reask,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="refrain")]
        Refrain,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValidatorReferenceOnFailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidatorReferenceOnFail value)
        {
            return value switch
            {
                ValidatorReferenceOnFail.Custom => "custom",
                ValidatorReferenceOnFail.Exception => "exception",
                ValidatorReferenceOnFail.Filter => "filter",
                ValidatorReferenceOnFail.Fix => "fix",
                ValidatorReferenceOnFail.FixReask => "fix_reask",
                ValidatorReferenceOnFail.Noop => "noop",
                ValidatorReferenceOnFail.Reask => "reask",
                ValidatorReferenceOnFail.Refrain => "refrain",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidatorReferenceOnFail? ToEnum(string value)
        {
            return value switch
            {
                "custom" => ValidatorReferenceOnFail.Custom,
                "exception" => ValidatorReferenceOnFail.Exception,
                "filter" => ValidatorReferenceOnFail.Filter,
                "fix" => ValidatorReferenceOnFail.Fix,
                "fix_reask" => ValidatorReferenceOnFail.FixReask,
                "noop" => ValidatorReferenceOnFail.Noop,
                "reask" => ValidatorReferenceOnFail.Reask,
                "refrain" => ValidatorReferenceOnFail.Refrain,
                _ => null,
            };
        }
    }
}