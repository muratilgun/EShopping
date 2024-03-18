using Catalog.Application.Extensions;
using Catalog.Application.Features.Types.Queries.GetAllTypes;
using Catalog.Application.Services.IRepositories;
using MediatR;

namespace Catalog.Application.Features.Types.Queries.GetAllTypes;
public class GetAllTypesQueryHandler(ITypeRepository repository)
    : IRequestHandler<GetAllTypesQuery, IList<GetAllTypesResponse>>
{
    public async Task<IList<GetAllTypesResponse>> Handle(GetAllTypesQuery request, CancellationToken cancellationToken)
    {
        var types = await repository.GetAllTypes();
        var response = MapperExtensions.LazyMapper.Map<IList<GetAllTypesResponse>>(types);
        return response;
    }
}