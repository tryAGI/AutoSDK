using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Naming.Methods;

public class OperationIdGenerator : IMethodNameGenerator
{
    public string? TryGenerate(OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        var operationId = operation.Operation.OperationId;
        if (operationId == null)
        {
            return null;
        }

        if (operation.Settings.StripRedundantOperationIdTagPrefixes)
        {
            operationId = StripRedundantTagPrefix(operationId, operation.Tag);
        }

        return operationId
            .ToPropertyName()
            .UseWordSeparator(CSharpMethodNamingSeparators.MethodSeparators);
    }

    private static string StripRedundantTagPrefix(string operationId, Tag tag)
    {
        var candidates = new[] { tag.Name, tag.SafeName, tag.SingularizedName }
            .Where(static value => !string.IsNullOrWhiteSpace(value))
            .Select(NormalizeGroupName)
            .Where(static candidate => candidate.Length > 0)
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .OrderByDescending(static candidate => candidate.Length);

        foreach (var candidate in candidates)
        {
            var consumedLength = GetMatchingPrefixLength(operationId, candidate);
            if (consumedLength == 0 || consumedLength >= operationId.Length)
            {
                continue;
            }

            var remainderStart = consumedLength;
            if (IsMethodSeparator(operationId[remainderStart]))
            {
                while (remainderStart < operationId.Length && IsMethodSeparator(operationId[remainderStart]))
                {
                    remainderStart++;
                }
            }
            else if (!char.IsUpper(operationId[remainderStart]))
            {
                continue;
            }

            if (remainderStart < operationId.Length)
            {
                return operationId.Substring(remainderStart);
            }
        }

        return operationId;
    }

    private static string NormalizeGroupName(string value)
    {
        return new string(value
            .Where(char.IsLetterOrDigit)
            .Select(char.ToLowerInvariant)
            .ToArray());
    }

    private static int GetMatchingPrefixLength(string operationId, string normalizedGroupName)
    {
        var groupIndex = 0;
        for (var operationIndex = 0; operationIndex < operationId.Length; operationIndex++)
        {
            var current = operationId[operationIndex];
            if (!char.IsLetterOrDigit(current))
            {
                continue;
            }

            if (groupIndex >= normalizedGroupName.Length ||
                char.ToLowerInvariant(current) != normalizedGroupName[groupIndex])
            {
                return 0;
            }

            groupIndex++;
            if (groupIndex == normalizedGroupName.Length)
            {
                return operationIndex + 1;
            }
        }

        return 0;
    }

    private static bool IsMethodSeparator(char value)
    {
        return Array.IndexOf(CSharpMethodNamingSeparators.MethodSeparators, value) >= 0;
    }
}
