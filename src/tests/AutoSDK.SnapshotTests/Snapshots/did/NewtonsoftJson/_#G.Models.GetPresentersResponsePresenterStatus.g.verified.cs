//HintName: G.Models.GetPresentersResponsePresenterStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the presenter
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetPresentersResponsePresenterStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rejected")]
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="started")]
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPresentersResponsePresenterStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresentersResponsePresenterStatus value)
        {
            return value switch
            {
                GetPresentersResponsePresenterStatus.Done => "done",
                GetPresentersResponsePresenterStatus.Error => "error",
                GetPresentersResponsePresenterStatus.Rejected => "rejected",
                GetPresentersResponsePresenterStatus.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresentersResponsePresenterStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => GetPresentersResponsePresenterStatus.Done,
                "error" => GetPresentersResponsePresenterStatus.Error,
                "rejected" => GetPresentersResponsePresenterStatus.Rejected,
                "started" => GetPresentersResponsePresenterStatus.Started,
                _ => null,
            };
        }
    }
}