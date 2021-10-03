Datto Commerce Hello Challenge
------------------------------

Hi! Thanks for your interest in joining our team.

To help us get to know your work we've got a quick challenge for you. We expect
that this won't take you more than 30 minutes.

# Challenge

## Setup

Imagine that we're shipping some products to customers. We use a couple of
different carriers, *QuickShip* and *SendIt*. Both these carriers provide
simple API clients that you can use to calculate shipping costs.

*QuickShip* are particularly convenient because they just give you back a
price directly.

*SendIt* aren't quite so advanced and they just return a rate card. Their
rates are always valid indefinitely, so we don't need to worry about them
changing while the challenge is running.

## What you need to do

What we need you to do is implement the `SelectBestCarrierAsync` method
in the `ShippingOptimiser`. This is responsible for taking a shipment
(which has a list of items being shipped) and choosing the cheapest
carrier.

QuickShip is easy, SendIt will require a little more work from you to
apply the rules in the returned rates.

## What we don't need you to do

This is just meant to be a quick challenge, so we don't need you to
spend time writing unit tests. We'd much rather you spent time making
your solution to the challenge a good example of the kind of code you'd
like write.

If you want to write unit tests or a test harness for your
own use then feel free, but we won't consider anything outside the
implementation in the ShippingOptimiser for the purpose of evaluating
this challenge.

## What are we evaluating?

* Does your solution work?
* Is your code correct, i.e. is it potentially going to crash?
* Is your code tidy, efficient, and appropriate for the problem?
* Do you make effective use of the language and framework?

## Notes

We have a Keystone.HelloChallenge.Clients.Abstractions class that
contains the interfaces and models used by our simulated API clients.
This is provided for your reference.

The actual concrete implementations of these clients is in an assembly
in the `lib` folder. You don't need to know anything about this, treat it
as a black box and imagine the implementation could change at any time.
