//HintName: G.Models.DeleteAddOnsProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteAddOnsProductType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alerts")]
        Alerts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="evals")]
        Evals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiments")]
        Experiments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompts")]
        Prompts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteAddOnsProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAddOnsProductType value)
        {
            return value switch
            {
                DeleteAddOnsProductType.Alerts => "alerts",
                DeleteAddOnsProductType.Evals => "evals",
                DeleteAddOnsProductType.Experiments => "experiments",
                DeleteAddOnsProductType.Prompts => "prompts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAddOnsProductType? ToEnum(string value)
        {
            return value switch
            {
                "alerts" => DeleteAddOnsProductType.Alerts,
                "evals" => DeleteAddOnsProductType.Evals,
                "experiments" => DeleteAddOnsProductType.Experiments,
                "prompts" => DeleteAddOnsProductType.Prompts,
                _ => null,
            };
        }
    }
}