﻿//HintName: G.Models.ReposListCollaboratorsPermission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReposListCollaboratorsPermission
    {
        /// <summary>
        /// 
        /// </summary>
        Pull,
        /// <summary>
        /// 
        /// </summary>
        Triage,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        Maintain,
        /// <summary>
        /// 
        /// </summary>
        Admin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListCollaboratorsPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListCollaboratorsPermission value)
        {
            return value switch
            {
                ReposListCollaboratorsPermission.Pull => "pull",
                ReposListCollaboratorsPermission.Triage => "triage",
                ReposListCollaboratorsPermission.Push => "push",
                ReposListCollaboratorsPermission.Maintain => "maintain",
                ReposListCollaboratorsPermission.Admin => "admin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListCollaboratorsPermission? ToEnum(string value)
        {
            return value switch
            {
                "pull" => ReposListCollaboratorsPermission.Pull,
                "triage" => ReposListCollaboratorsPermission.Triage,
                "push" => ReposListCollaboratorsPermission.Push,
                "maintain" => ReposListCollaboratorsPermission.Maintain,
                "admin" => ReposListCollaboratorsPermission.Admin,
                _ => null,
            };
        }
    }
}