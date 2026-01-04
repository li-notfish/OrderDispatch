namespace OrderDispatch.WebApi
{
    public enum DeliveryState
    {
        // 订单处理阶段
        Pending = 1,        // 待接单
        Assigned = 2,       // 已接单

        // 取货阶段与配送
        ArrivedAtStore = 3, // 已到店
        PickedUp = 4,       // 已取货
        Delivering = 5,     // 配送中
        Arrived = 6,        // 已到达用户地址

        // 完成阶段
        Completed = 7,      // 已完成

        // 异常状态
        Cancelled = 8,     // 已取消
        Failed = 9,        // 配送失败
        Returned = 10       // 已退回
    }
}
