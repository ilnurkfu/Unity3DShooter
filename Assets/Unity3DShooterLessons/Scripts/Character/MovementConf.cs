[System.Serializable]
public struct MovementConf
{
    public float sprintMultiplier;
    public float speed;
    public float jumpHeight;

    public MovementConf(float sprintMultiplier, float speed, float jumpHeight)
    {
        this.sprintMultiplier = sprintMultiplier;
        this.speed = speed;
        this.jumpHeight = jumpHeight;
    }
}
