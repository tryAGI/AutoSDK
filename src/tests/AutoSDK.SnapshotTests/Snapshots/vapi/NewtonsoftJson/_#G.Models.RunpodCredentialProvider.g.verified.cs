//HintName: G.Models.RunpodCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunpodCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="runpod")]
        Runpod,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunpodCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunpodCredentialProvider value)
        {
            return value switch
            {
                RunpodCredentialProvider.Runpod => "runpod",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunpodCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "runpod" => RunpodCredentialProvider.Runpod,
                _ => null,
            };
        }
    }
}