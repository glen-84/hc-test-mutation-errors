namespace hc_test_mutation_errors.Types;

[MutationType]
public static class Mutation
{
    public static MutationResult<DateOnly, MyError> GetDate()
        => DateOnly.FromDateTime(DateTime.UtcNow);
}
