using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class NewsManager : MonoBehaviour {

    public static List<News> news = new List<News>();
    private static Boolean initialized = false;
	// Use this for initialization
	void Start () {
        if (initialized)
            return;
        news.Add(new News("Vremenska napoved", "V ponedeljek in torek bo v zahodni polovici Slovenije pretežno oblačno, predvsem v hribovitem svetu bodo občasne padavine. Na vzhodu bo nekaj več sonca. Ponekod bo pihal južni do jugozahodni veter, ob morju jugo.", NewsType.Weather, EffectType.lowerDemand));
        news.Add(new News("Javno zbiranje ponudb za prodajo nepremičnin", " Zemljišče, parc. št. 2224/1, k.o. 681-Pobrežje, bo prodano po metodi javnega zbiranja ponudb, najmanj po izhodiščni ceni 250.750,00 EUR. V ceni ni zajet DDV. Komunalni prispevek bo zaračunan pred izdajo gradbenega dovoljenja in ni zajet v ceni za m2 zemljišča, za kar bo izdana posebna odločba", NewsType.Siol, EffectType.higherDemand));
        news.Add(new News("Horizon 2020 Dedicated SME Instrument - PHASE 1 2015", "The SME instrument consists of three separate phases and a coaching and mentoring service for beneficiaries. Participants can apply to phase 1 with a view to applying to phase 2 at a later date, or directly to phase 2.", NewsType._24ur, EffectType.lowerDemand));
        initialized = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
