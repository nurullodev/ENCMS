﻿using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.IRepositories;
using CMS.Domain.Entities.DesignTools;

namespace CMS.Data.Repositories;

public class DesignToolRepository : Repository<DesignTool>, IDesignToolRepository
{
    public DesignToolRepository(AppDbContext appDbContext) : base(appDbContext)
    {

    }
}