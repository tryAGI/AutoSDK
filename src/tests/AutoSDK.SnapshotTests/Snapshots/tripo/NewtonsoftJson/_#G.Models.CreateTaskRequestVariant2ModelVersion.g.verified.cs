//HintName: G.Models.CreateTaskRequestVariant2ModelVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTaskRequestVariant2ModelVersion
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
    public static class CreateTaskRequestVariant2ModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant2ModelVersion value)
        {
            return value switch
            {
                CreateTaskRequestVariant2ModelVersion.Default => "default",
                CreateTaskRequestVariant2ModelVersion.V1320240522 => "v1.3-20240522",
                CreateTaskRequestVariant2ModelVersion.V1420240625 => "v1.4-20240625",
                CreateTaskRequestVariant2ModelVersion.V2020240919 => "v2.0-20240919",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant2ModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateTaskRequestVariant2ModelVersion.Default,
                "v1.3-20240522" => CreateTaskRequestVariant2ModelVersion.V1320240522,
                "v1.4-20240625" => CreateTaskRequestVariant2ModelVersion.V1420240625,
                "v2.0-20240919" => CreateTaskRequestVariant2ModelVersion.V2020240919,
                _ => null,
            };
        }
    }
}