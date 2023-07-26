"use client";
import { useSession } from "next-auth/react";

export default function Home() {
  const { data: session, status } = useSession();

  return (
    <div className="container ">
      <h1>Home</h1>
      <p>This is the home page</p>
      {session?.user?.email}
    </div>
  );
}
