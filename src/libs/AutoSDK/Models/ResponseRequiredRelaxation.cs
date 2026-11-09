namespace AutoSDK.Models;

/// <summary>
/// How much of a response schema's <c>required</c> list to drop at generation time.
/// </summary>
/// <remarks>
/// The generated deserializers enforce <c>required</c>, so a response field the service omits turns
/// a successful HTTP 200 into a JSON exception. How far to go is a judgement call, which is why this
/// is a mode rather than a switch.
/// </remarks>
public enum ResponseRequiredRelaxation
{
    /// <summary>
    /// Keep every <c>required</c> the spec declares. The default: a mismatch is reported as a
    /// warning so it can be confirmed against the real service first.
    /// </summary>
    None = 0,

    /// <summary>
    /// Drop <c>required</c> only where the property also declares a <c>default</c> - the spec
    /// contradicting itself, since a default is what omitting the field means.
    /// </summary>
    Defaulted,

    /// <summary>
    /// Drop <c>required</c> from every response field. Use where live traffic has shown the spec
    /// demands fields the service does not send and the list is not worth enumerating - Label
    /// Studio's `UserSimple.username`, required with no default and never sent, is the case this
    /// exists for.
    /// </summary>
    All,
}
