using AutoSDK.Helpers;
using System.Collections.Immutable;

namespace AutoSDK.Models;

public record struct ModelData(
    SchemaContext SchemaContext,
    string Id,
    ImmutableArray<Box> Parents,
    string Namespace,
    EmitterSettings Settings,
    ModelStyle Style,
    ImmutableArray<PropertyData> Properties,
    ImmutableArray<PropertyData> EnumValues,
    string Summary,
    string Description,
    bool IsDeprecated,
    string DeprecationMessage,
    string BaseClass,
    bool HasDeprecatedBaseClass,
    bool IsBaseClass,
    bool IsDerivedClass,
    ImmutableArray<string> InheritedPropertyNames,
    string DiscriminatorPropertyName,
    EquatableArray<(string GlobalClassName, string Discriminator)> DerivedTypes,
    string ClassName,
    string GlobalClassName,
    string ExternalClassName,
    string FileNameWithoutExtension
);
