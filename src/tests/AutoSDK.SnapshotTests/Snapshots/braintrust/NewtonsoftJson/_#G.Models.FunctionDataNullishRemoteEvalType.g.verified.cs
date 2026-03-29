//HintName: G.Models.FunctionDataNullishRemoteEvalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FunctionDataNullishRemoteEvalType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="remote_eval")]
        RemoteEval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataNullishRemoteEvalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataNullishRemoteEvalType value)
        {
            return value switch
            {
                FunctionDataNullishRemoteEvalType.RemoteEval => "remote_eval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataNullishRemoteEvalType? ToEnum(string value)
        {
            return value switch
            {
                "remote_eval" => FunctionDataNullishRemoteEvalType.RemoteEval,
                _ => null,
            };
        }
    }
}