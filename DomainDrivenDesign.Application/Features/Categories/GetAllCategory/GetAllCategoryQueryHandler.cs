﻿using DomainDrivenDesign.Domain.Categories;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Categories.GetAllCategory;

internal sealed class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, List<Category>>
{
  
    private readonly ICategoryRepository _categoryRepository;

    public GetAllCategoryQueryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<Category>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
    {
        return await _categoryRepository.GetAllAsync(cancellationToken);
    }
}
