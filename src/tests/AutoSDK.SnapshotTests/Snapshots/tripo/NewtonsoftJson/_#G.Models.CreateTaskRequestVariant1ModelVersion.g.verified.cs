//HintName: G.Models.CreateTaskRequestVariant1ModelVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTaskRequestVariant1ModelVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="v1.3-20240522")]
        V1320240522,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="v1.4-20240625")]
        V1420240625,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="v2.0-20240919")]
        V2020240919,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant1ModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant1ModelVersion value)
        {
            return value switch
            {
                CreateTaskRequestVariant1ModelVersion.Default => "default",
                CreateTaskRequestVariant1ModelVersion.V1320240522 => "v1.3-20240522",
                CreateTaskRequestVariant1ModelVersion.V1420240625 => "v1.4-20240625",
                CreateTaskRequestVariant1ModelVersion.V2020240919 => "v2.0-20240919",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant1ModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateTaskRequestVariant1ModelVersion.Default,
                "v1.3-20240522" => CreateTaskRequestVariant1ModelVersion.V1320240522,
                "v1.4-20240625" => CreateTaskRequestVariant1ModelVersion.V1420240625,
                "v2.0-20240919" => CreateTaskRequestVariant1ModelVersion.V2020240919,
                _ => null,
            };
        }
    }
}