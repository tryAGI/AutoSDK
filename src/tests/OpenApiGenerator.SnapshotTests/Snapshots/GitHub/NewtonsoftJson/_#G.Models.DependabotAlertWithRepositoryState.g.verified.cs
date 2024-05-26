﻿//HintName: G.Models.DependabotAlertWithRepositoryState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the Dependabot alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertWithRepositoryState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto_dismissed")]
        AutoDismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }
}