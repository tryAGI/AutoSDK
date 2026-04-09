using AutoSDK.Extensions;
using AutoSDK.Models;
using System.Text;

namespace AutoSDK.Naming.Properties;

public static class CSharpPropertyNameGenerator
{
    private static readonly char[] PropertySeparators =
        ['_', '+', '-', '.', '/', '(', '[', ']', ')'];

    private static readonly Dictionary<string, string> ObjectMemberCollisionNames = new(StringComparer.Ordinal)
    {
        ["Equals"] = "EqualsValue",
        ["ToString"] = "ToStringValue",
        ["GetHashCode"] = "GetHashCodeValue",
        ["GetType"] = "GetTypeValue",
    };

    public static string ComputePropertyName(
        SchemaContext context)
    {
        context = context ?? throw new ArgumentNullException(nameof(context));
        var propertyName = context.PropertyName ?? throw new InvalidOperationException("Property name or parameter name is required.");
        if (context.Settings.UseExtensionNaming &&
            OpenApiExtensions.TryGetPropertyNameOverride(context.Schema.Extensions, out var propertyNameOverride) &&
            !string.IsNullOrWhiteSpace(propertyNameOverride))
        {
            propertyName = propertyNameOverride;
        }

        var name = propertyName.ToPropertyName();

        name = HandleWordSeparators(name);

        if (context.Parent != null)
        {
            name = name.FixPropertyName(context.Parent.Id);
        }

        name = SanitizeName(name, context.Settings.ClsCompliantEnumPrefix, true, context.Settings.IdentifierCharacterSet);
        name = AvoidObjectMemberNameCollision(name);

        return name;
    }

    public static string SanitizeName(
        string? name,
        string clsCompliantEnumPrefix,
        bool skipHandlingWordSeparators = false,
        IdentifierCharacterSet identifierCharacterSet = IdentifierCharacterSet.UnicodeLetters)
    {
        if (name is null || name.Length == 0)
        {
            return "";
        }

        if (!skipHandlingWordSeparators)
        {
            name = HandleWordSeparators(name);
        }

        if (name.Length == 0)
        {
            return string.IsNullOrWhiteSpace(clsCompliantEnumPrefix)
                ? "_"
                : clsCompliantEnumPrefix;
        }

        if (!CSharpIdentifierCharacterRules.IsValidIdentifierStart(name, 0, identifierCharacterSet))
        {
            name = (string.IsNullOrWhiteSpace(clsCompliantEnumPrefix)
                ? "_"
                : clsCompliantEnumPrefix) + name;
        }

        var needsSanitize = false;
        for (var i = 0; i < name.Length; i += CSharpIdentifierCharacterRules.GetCodePointLength(name, i))
        {
            var isValid = i == 0
                ? CSharpIdentifierCharacterRules.IsValidIdentifierStart(name, i, identifierCharacterSet)
                : CSharpIdentifierCharacterRules.IsValidIdentifierPart(name, i, identifierCharacterSet);
            if (!isValid)
            {
                needsSanitize = true;
                break;
            }
        }
        if (!needsSanitize)
        {
            return name;
        }

        var builder = new StringBuilder(name.Length);
        for (var i = 0; i < name.Length; i += CSharpIdentifierCharacterRules.GetCodePointLength(name, i))
        {
            var codePointLength = CSharpIdentifierCharacterRules.GetCodePointLength(name, i);
            var isValid = i == 0
                ? CSharpIdentifierCharacterRules.IsValidIdentifierStart(name, i, identifierCharacterSet)
                : CSharpIdentifierCharacterRules.IsValidIdentifierPart(name, i, identifierCharacterSet);
            if (isValid)
            {
                builder.Append(name, i, codePointLength);
            }
            else
            {
                builder.Append('_');
            }
        }

        return builder.ToString();
    }

    public static string HandleWordSeparators(string name)
    {
        return name
            .ReplacePlusAndMinusOnStart()
            .UseWordSeparator(PropertySeparators);
    }

    public static string ToCSharpName(this string text, SchemaNamingSettings settings, SchemaContext? parent)
    {
        var name = text.ToPropertyName();

        name = HandleWordSeparators(name);

        if (parent != null)
        {
            name = name.FixPropertyName(parent.Id);
        }

        return SanitizeName(name, settings.ClsCompliantEnumPrefix, true, settings.IdentifierCharacterSet);
    }

    public static string ToCSharpName(this string text, CSharpSettings settings, SchemaContext? parent)
    {
        return text.ToCSharpName(settings.ToSchemaNamingSettings(), parent);
    }

    public static string ToCSharpName(this string text, SchemaContextSettings settings, SchemaContext? parent)
    {
        return text.ToCSharpName(settings.ToSchemaNamingSettings(), parent);
    }

    public static string AvoidObjectMemberNameCollision(string name)
    {
        return ObjectMemberCollisionNames.TryGetValue(name, out var replacement)
            ? replacement
            : name;
    }
}
