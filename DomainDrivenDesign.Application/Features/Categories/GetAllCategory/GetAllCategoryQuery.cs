﻿using DomainDrivenDesign.Domain.Categories;
using MediatR;

namespace DomainDrivenDesign.Application.Features.Categories.GetAllCategory;

public sealed  record GetAllCategoryQuery():IRequest<List<Category>>;
