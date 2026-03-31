//HintName: G.Models.FunctionDataRemoteEvalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FunctionDataRemoteEvalType
    {
        /// <summary>
        /// 
        /// </summary>
        RemoteEval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FunctionDataRemoteEvalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FunctionDataRemoteEvalType value)
        {
            return value switch
            {
                FunctionDataRemoteEvalType.RemoteEval => "remote_eval",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FunctionDataRemoteEvalType? ToEnum(string value)
        {
            return value switch
            {
                "remote_eval" => FunctionDataRemoteEvalType.RemoteEval,
                _ => null,
            };
        }
    }
}