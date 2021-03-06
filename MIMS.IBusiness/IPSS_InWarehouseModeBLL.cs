﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIMS.Entity.Model;

namespace MIMS.IBusiness
{

    public interface IPSS_InWarehouseModeBLL
    {
        /// <summary>
        /// 获取一个list的数据
        /// </summary>
        /// <returns></returns>
        IList GetList();
        /// <summary>
        /// 根据主键值获得一个对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PSS_InWarehouseMode GetEntity(string id);

        int Update(PSS_InWarehouseMode obj);

        int Insert(PSS_InWarehouseMode obj);
        int Delete(PSS_InWarehouseMode obj);
    }
}
