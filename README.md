# CoinWarsPhysicsSim
Use coroutines and interpolation to simulate physics in Coin Wars--useful for AIs and perhaps for server-side physics if networked..

Made with Unity3d 5.
You can fool around with coins by opening up the scene Assets>PhysicsAI>Scenes>physicstrial

And see a demo here:<br>
https://www.youtube.com/watch?v=iVINncMEavo

Basically Unity3d is only used in this scene to render the coin (and the platform...prolla wasting a lot of draw calls)<br>
So just rendering, my code handles the actual simulating physics. So Unity3d's physics engine not used at all.

Hope is that this can be used to build from. To build AI more efficiently-ex as heuristics to inform the effects of actions. What's nice is that this is deterministic, fixed computations given a board configuration and a launch vector of how where the coins will end up.<br>
Credit must be given to http://www.gamasutra.com/view/feature/131424/pool_hall_lessons_fast_accurate_.php for the linear algebra optimizations I used
