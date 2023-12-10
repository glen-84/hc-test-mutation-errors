namespace hc_test_mutation_errors.Types;

public class MyErrorType : ObjectType<MyError>
{
    protected override void Configure(IObjectTypeDescriptor<MyError> descriptor)
    {
        descriptor.BindFieldsImplicitly(); // should be enough.

        descriptor.Field(e => e.Message); // this doesn't work either.
    }
}
