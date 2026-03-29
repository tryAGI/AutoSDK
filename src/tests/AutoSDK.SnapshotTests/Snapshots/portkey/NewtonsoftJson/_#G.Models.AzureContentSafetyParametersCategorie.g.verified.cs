//HintName: G.Models.AzureContentSafetyParametersCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AzureContentSafetyParametersCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Hate")]
        Hate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SelfHarm")]
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Sexual")]
        Sexual,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Violence")]
        Violence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureContentSafetyParametersCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureContentSafetyParametersCategorie value)
        {
            return value switch
            {
                AzureContentSafetyParametersCategorie.Hate => "Hate",
                AzureContentSafetyParametersCategorie.SelfHarm => "SelfHarm",
                AzureContentSafetyParametersCategorie.Sexual => "Sexual",
                AzureContentSafetyParametersCategorie.Violence => "Violence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureContentSafetyParametersCategorie? ToEnum(string value)
        {
            return value switch
            {
                "Hate" => AzureContentSafetyParametersCategorie.Hate,
                "SelfHarm" => AzureContentSafetyParametersCategorie.SelfHarm,
                "Sexual" => AzureContentSafetyParametersCategorie.Sexual,
                "Violence" => AzureContentSafetyParametersCategorie.Violence,
                _ => null,
            };
        }
    }
}