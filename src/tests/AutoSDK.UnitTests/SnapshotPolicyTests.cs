namespace AutoSDK.Tests;

[TestClass]
public class SnapshotPolicyTests : VerifyBase
{
    [TestMethod]
    public async Task SnapshotMismatch_FailsAndPreservesVerifiedBaseline()
    {
        var directory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(directory);
        var baseline = Path.Combine(directory, "policy.verified.txt");
        const string original = "reviewed baseline";
        try
        {
            await File.WriteAllTextAsync(baseline, original);
            var failure = await Assert.ThrowsAsync<Exception>(async () =>
                await Verify("unreviewed change")
                    .UseDirectory(directory)
                    .UseFileName("policy")
                    .DisableDiff());

            failure.Message.Should().Contain("policy.received.txt");
            (await File.ReadAllTextAsync(baseline)).Should().Be(original);
            (await File.ReadAllTextAsync(Path.Combine(directory, "policy.received.txt")))
                .Should().Contain("unreviewed change");
        }
        finally
        {
            Directory.Delete(directory, recursive: true);
        }
    }
}
