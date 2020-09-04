#region << 版 本 注 释 >>
//----------------------------------------------------------------
// Copyright © 2020  版权所有：湖南办事处（IT-hezhijin）
// 唯一码：6a251a76-0e1b-45e7-9697-97faa25083ea
// 文件名：SQLExpressionVisitor
// 文件功能描述：
// 创建者：HZJ-(zhijinhe2020) 
// 计算机名：IT-HZJ
// QQ: 413961980
// 时间：2020-09-01 17:16:53
// 修改人：HZJ-(zhijinhe2020) 
// 时间：2020-09-01 17:16:53
// 修改说明：
// 版本：V1.0.0   当前系统CLR（运行时版.NET）版本号:4.0.30319.42000
//----------------------------------------------------------------
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RightingSys.DAL.Sql.ExpressionExtend
{
    /// <summary>
    /// 表达式目录树分析 To SQL 条件语句
    /// </summary>
    public class SQLExpressionVisitor:ExpressionVisitor
    {
        private Stack<string> ConditionStack = new Stack<string>();

        public override Expression Visit(Expression node)
        {
            return base.Visit(node);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            return base.VisitBinary(node);
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            return base.VisitMethodCall(node);
        }

       
    }
}
