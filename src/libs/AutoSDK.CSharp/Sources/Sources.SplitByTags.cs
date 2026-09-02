using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    /// <summary>
    /// Accessibility modifier for shared runtime members that generated tag assemblies call across
    /// an assembly boundary once <c>--split-by-tags</c> is on.
    /// </summary>
    /// <remarks>
    /// In the default single-project mode this is plain <c>internal</c> and nothing changes. In
    /// split mode the members are widened to <c>public</c> and marked
    /// <c>[EditorBrowsable(Never)]</c> so they stay out of consumer IntelliSense — unless a
    /// strong-name public key was supplied, in which case they stay <c>internal</c> and the
    /// generated projects emit <c>InternalsVisibleTo</c> across the family instead.
    /// The attribute is emitted on the same line as the modifier so the templates' blank-line
    /// handling (see the trailing-space convention in CLAUDE.md) is unaffected.
    /// </remarks>
    internal static string SharedMemberModifier(Settings settings)
    {
        return settings.HidesSharedMembersFromIntelliSense
            ? "[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)] public"
            : "internal";
    }

    /// <summary>
    /// Accessibility modifier for members declared inside a type that
    /// <see cref="SharedMemberModifier"/> already widened.
    /// </summary>
    /// <remarks>
    /// The containing type carries the <c>[EditorBrowsable(Never)]</c> marker, so its members do
    /// not need to repeat it — they only need to be reachable.
    /// </remarks>
    internal static string SharedNestedMemberModifier(Settings settings)
    {
        return settings.HidesSharedMembersFromIntelliSense ? "public" : "internal";
    }

    /// <summary>
    /// Fully-qualified reference to one of the generated OAuth2 support types.
    /// </summary>
    /// <remarks>
    /// These types are normally nested inside the root client class. That is fine for a single
    /// assembly, but in split mode the root client lives in the facade while tag clients and their
    /// operation bodies also need the coordinator and the send helper — which would make every tag
    /// assembly reference the facade that already references it. So split mode emits the family as
    /// namespace-level types in the Core package and points every reference there instead.
    /// </remarks>
    internal static string OAuth2TypeReference(Settings settings, string typeName)
    {
        return settings.SplitByTags
            ? $"global::{settings.Namespace}.{typeName}"
            : $"global::{settings.Namespace}.{settings.ClassName.Replace(".", string.Empty)}.{typeName}";
    }
}
