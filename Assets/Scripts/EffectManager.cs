using System.Collections;

public class EffectManager {

    public static void affect(EffectType effect)
    {
        switch (effect)
        {
            case EffectType.lowerDemand:
                GameManager.lowerDemand();
                break;
            case EffectType.higherDemand:
                GameManager.higherDemand();
                break;
            default:
                break;
        }
    }
}
