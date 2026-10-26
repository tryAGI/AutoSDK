using AutoSDK.Models;
using AutoSDK.TypeMapping;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class RuntimeScalarClassificationTests
{
    [TestMethod]
    public void MissingCollisionCandidate_IsNotAValueType() =>
        default(TypeData).IsRuntimeValueType().Should().BeFalse();

    [TestMethod]
    [DataRow("bool", true)]
    [DataRow("int", true)]
    [DataRow("global::System.DateTime", true)]
    [DataRow("global::System.DateTimeOffset", true)]
    [DataRow("global::System.Guid", true)]
    [DataRow("string", false)]
    [DataRow("byte[]", false)]
    [DataRow("string[]", false)]
    [DataRow("global::System.Collections.Generic.IList<global::System.DateTime?>", false)]
    [DataRow("global::System.Collections.Generic.Dictionary<string, int?>", false)]
    public void Metadata_UsesClrCategoryWithoutChangingLegacyHookFlags(string emittedType, bool valueType)
    {
        foreach (var legacy in new[] { true, false })
        {
            var type = (TypeData.Default with
            {
                CSharpTypeRaw = emittedType, IsValueType = legacy, CSharpTypeNullability = true,
            }).WithCSharpComputedValues();
            type.IsRuntimeValueType().Should().Be(valueType);
            AutoSDK.Serialization.Json.SystemTextJsonSerializer.GetContextType(type, makeNullableRootIfValueType: true)
                .StartsWith("Nullable", StringComparison.Ordinal).Should().Be(valueType);
            type.IsValueType.Should().Be(legacy);
            type.CSharpType.Should().Be(emittedType + "?");
            type.CSharpTypeWithNullabilityForValueTypes.Should().Be(legacy ? emittedType + "?" : emittedType);
        }
    }
}
