﻿/******************************************************************
**Author:  Foolyoo	
**Date:    2020-11-01 
**Describe:所有的消息的定义
********************************************************************/
namespace FootStone
{
    //消息定义规则
    //CLLS(客户端发送到登陆服)
    //LSCL(登陆服发送到客户端)
    //CLGS(客户端发送到逻辑服)
    //GSCL(逻辑服发送到客户端)
    //例：CLLS_Login    //玩家登陆
    public enum NetMessageDefine
    { 
        //(CLLS 1-10)
        CLLS_Login = 1,                                                                                              //玩家登陆
        CLLS_CreateActor,                                                                                            //角色创建
        CLLS_DeleteActor,                                                                                            //删除角色
        CLLS_ChangeName,                                                                                             //角色改名




    }
}
