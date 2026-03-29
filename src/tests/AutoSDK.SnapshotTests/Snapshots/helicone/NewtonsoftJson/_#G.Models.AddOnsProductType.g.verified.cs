//HintName: G.Models.AddOnsProductType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AddOnsProductType
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
    public static class AddOnsProductTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddOnsProductType value)
        {
            return value switch
            {
                AddOnsProductType.Alerts => "alerts",
                AddOnsProductType.Evals => "evals",
                AddOnsProductType.Experiments => "experiments",
                AddOnsProductType.Prompts => "prompts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddOnsProductType? ToEnum(string value)
        {
            return value switch
            {
                "alerts" => AddOnsProductType.Alerts,
                "evals" => AddOnsProductType.Evals,
                "experiments" => AddOnsProductType.Experiments,
                "prompts" => AddOnsProductType.Prompts,
                _ => null,
            };
        }
    }
}