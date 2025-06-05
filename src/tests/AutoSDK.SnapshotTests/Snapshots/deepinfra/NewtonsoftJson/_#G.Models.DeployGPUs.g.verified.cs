//HintName: G.Models.DeployGPUs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeployGPUs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="A100-80GB")]
        A10080GB,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="H100-80GB")]
        H10080GB,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="H200-141GB")]
        H200141GB,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="B200-180GB")]
        B200180GB,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeployGPUsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeployGPUs value)
        {
            return value switch
            {
                DeployGPUs.A10080GB => "A100-80GB",
                DeployGPUs.H10080GB => "H100-80GB",
                DeployGPUs.H200141GB => "H200-141GB",
                DeployGPUs.B200180GB => "B200-180GB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeployGPUs? ToEnum(string value)
        {
            return value switch
            {
                "A100-80GB" => DeployGPUs.A10080GB,
                "H100-80GB" => DeployGPUs.H10080GB,
                "H200-141GB" => DeployGPUs.H200141GB,
                "B200-180GB" => DeployGPUs.B200180GB,
                _ => null,
            };
        }
    }
}